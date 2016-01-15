using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Settings = Report_Builder.Properties.Settings;

namespace Report_Builder
{
	public partial class MainForm : Form
	{
		#region ГЛОБАЛЬНЫЕ ПЕРЕМЕННЫЕ
		// Хэш для хранения колчества проигрышей файлов
		private Hashtable tableCount;
		// Хэш для хранения длительности файла
		private Hashtable tableDuration;
		// Количество обработаных файлов
		private int filesCount;
		// Для работы с файлами Excel
		private Excel.Application excelapp;
		private Excel.Workbooks excelappworkbooks;
		private Excel.Workbook excelappworkbook;
		private Excel.Sheets excelsheets;
		private Excel.Worksheet excelworksheet;
		private Excel.Range excelcells;

		#endregion
		
		public MainForm()
		{
			// Инициализация компоненотов
			InitializeComponent();

			tableCount = new Hashtable();
			tableDuration = new Hashtable();
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Выходим из программы
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Если пользователь указал каталог записываем параметры
			if (DialogResult.OK == openFolder.ShowDialog())
			{
				Settings.Default.FilesDir = openFolder.SelectedPath;
				Settings.Default.Save();
			}
		}

		private void createReportButton_Click(object sender, EventArgs e)
		{

			if (Directory.Exists(Settings.Default.FilesDir))
			{
				createReportButton.Enabled = false;
				// Получаем список файлов в каталоге
				string[] filesArray = Directory.GetFiles(Settings.Default.FilesDir);

				foreach (string fileName in filesArray)
				{
					// Проверяем расширение файла
					FileInfo infoFile = new FileInfo(fileName);
					// Совпадает с датами формата: 1900-01-01 2007/08/13 1900.01.01 1900 01 01 1900-01.01
					//string fileNamePattern = @"(19|20)\d\d([- /.])(0[1-9]|1[012])([- /.])(0[1-9]|[12][0-9]|3[01])";
					string month;
					if (dateTimePicker1.Value.Month <= 9) { month = "0" + dateTimePicker1.Value.Month; }
					else { month = dateTimePicker1.Value.Month.ToString(); };
					string fileNamePattern;
					if (checkBox1.Checked)
					{
						fileNamePattern = "(" + dateTimePicker1.Value.Year + @")([- /.])(" 
							+ month	+ @")([- /.])(0[1-9]|[12][0-9]|3[01])";
					}
					else
					{
						fileNamePattern = ".";
					}
						
					// Обнуляем счётчик обработаных файлов
					filesCount = 0;
					if ((File.Exists(fileName)) && Regex.IsMatch(fileName, fileNamePattern) && (infoFile.Extension == ".dpm"))
					{
						filesCount++;
						// Создаём потоки чтения файлов.
						FileStream fileStream = new FileStream(
							fileName,
							FileMode.Open,
							FileAccess.Read
							);
						StreamReader streamReader = new StreamReader(
							fileStream,
							Encoding.GetEncoding(1251)
							);

						toolStripStatusLabel2.Text = "Обработка файла: " + infoFile.Name;
						// Считываем построчно файл до самого конца
						while (!streamReader.EndOfStream)
						{
							// Разделяем полученную строку
							// Структтура массива:
							//  info[0] - знак выхождения или выхода трека (">" или "<")
							//  info[1] - дата и время выхода пести
							//  info[2] - идентификатор трека при составлении плейлиста
							//  info[3] - псевдоним, который определяет положение треков на диске
							//  info[4] - имя файла трека относительно псевдонима
							//  info[5] - длительность трека
							string[] info = streamReader.ReadLine().Split('\t');

							// Считаем только вхождение файла
							// Т.е. проверяем на символ ">" и проверяем только определённый псевдоним
							string[] aliases = Properties.Settings.Default.Aliases.Split(';');
							foreach (string alias in aliases)
							{
								if ((info[0].Trim() == ">") && (info[3].Trim() == alias.Trim()))
								{
									if (!tableCount.Contains(info[4]))
									{
										// Если записи нет, создаём новую
										tableCount.Add(info[4], 1);
										tableDuration.Add(info[4], info[5]);
									}
									else
									{
										// Если запись есть, увеличиваем счётчик
										tableCount[info[4]] = (int)tableCount[info[4]] + 1;
									}
								}
							}
						}
						// Закрываем потоки чтения файлов.
						streamReader.Close();
						fileStream.Close();
					}	// End If File Exist
				} // End Foreach FileNames

				// Меняем статус
				toolStripStatusLabel2.Text = "Обработано файлов: " + filesCount;

				// Создаём нумератор для управление Хэш массивом
				IDictionaryEnumerator tableCountEnum = tableCount.GetEnumerator();

				toolStripStatusLabel2.Text = "Создание файла отчёта.";
				#region СОЗДАЁМ НОВЫЙ ДОКУМЕНТ EXCEL
				// Открываем приложение
				excelapp = new Excel.Application();
				// Прячем окно программы
				excelapp.Visible = false;
				// Создаём документ с одной книгой
				excelapp.SheetsInNewWorkbook = 1;
				// Добавляем книгу
				excelapp.Workbooks.Add(Type.Missing);

				//Запрашивать сохранение
				//excelapp.DisplayAlerts = true;
				excelapp.DisplayAlerts = false;
				//Получаем набор ссылок на объекты Workbook (на созданные книги)
				excelappworkbooks = excelapp.Workbooks;
				//Получаем ссылку на книгу 1 - нумерация от 1
				excelappworkbook = excelappworkbooks[1];
				#endregion

				toolStripStatusLabel2.Text = "Генерация отчёта.";
				#region РАБОТА С ЯЧЕЙКАМИ
				excelsheets = excelappworkbook.Worksheets;
				// Получаем ссылку на лист 1
				excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);

				#region Примеры: Выделение группы ячеек
				//excelcells = excelworksheet.get_Range("A1", "С10");
				// Тоже
				//excelcells = excelworksheet.get_Range("A1", "С10").Cells;
				//excelcells = excelworksheet.get_Range("A1", "С10").Rows;
				//excelcells = excelworksheet.get_Range("A1", "С10").Cells;
				// Одну ячейку
				//excelcells = excelworksheet.get_Range("A1", "A1");
				//excelcells = excelworksheet.get_Range("A1", Type.Missing);
				// Десять строк с 1 по 10ю
				//excelcells = (Excel.Range)excelworksheet.Rows["1:10", Type.Missing];
				// Три столбца
				//excelcells = (Excel.Range)excelworksheet.Columns["A:C", Type.Missing];
				// Одну строку
				//excelcells = (Excel.Range)excelworksheet.Rows["1", Type.Missing];
				// Один столбец
				//excelcells = (Excel.Range)excelworksheet.Columns["C", Type.Missing]; 
				#endregion

				// Выбираем первую ячейку
				excelcells = excelworksheet.get_Range("A1", Type.Missing).Cells;
				excelcells.Value2 = "Испольнитель";
				excelcells = excelworksheet.get_Range("B1", Type.Missing).Cells;
				excelcells.Value2 = "Трек";
				excelcells = excelworksheet.get_Range("C1", Type.Missing).Cells;
				excelcells.Value2 = "Длительность";
				excelcells = excelworksheet.get_Range("D1", Type.Missing).Cells;
				excelcells.Value2 = "Количество";

				excelcells = excelworksheet.get_Range("A1", "D1").Cells;
				excelcells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				#endregion

				#region ЗАПИСЫВАЕМ ДАННЫЕ В ФАЙЛ
				// Сбрасываем счётчик Хэша в начало
				tableCountEnum.Reset();

				// В цикле перебираем все записи Хэша
				for (int i = 0; i < tableCount.Count; i++)
				{
					// Переход к следующей записи
					tableCountEnum.MoveNext();
					// Выделяем имя файла из пути к файлу
					string trackName = Regex.Match(tableCountEnum.Key.ToString(), @"[^\\]*$").Value;
					// Отрезаем расширение файла
					trackName = trackName.Substring(0, trackName.Length - 4);
					// Заменяем тире с пробелами на знак %
					trackName = trackName.Replace("-", "%");
					// Разделяем название группы и название трека
					string[] fullName = trackName.Split('%');

					// Работаем с документом
					// Начинаем запись исполнителей со второй строки
					int m = i + 2;
					excelcells = (Excel.Range)excelworksheet.Cells[m, 1];
					excelcells.Value2 = fullName[0].Trim();
					excelcells = (Excel.Range)excelworksheet.Cells[m, 2];
					if (fullName.Length > 1) {excelcells.Value2 = fullName[1].Trim(); }
					excelcells = (Excel.Range)excelworksheet.Cells[m, 3];
					excelcells.Value2 = tableDuration[tableCountEnum.Key];
					excelcells = (Excel.Range)excelworksheet.Cells[m, 4];
					excelcells.Value2 = tableCountEnum.Value.ToString();
					
				}
				#endregion

				toolStripStatusLabel2.Text = "Сохранение документа.";
				#region ЗАВЕРШАЕМ РАБОТУ С EXCEL
				//Ссылку можно получить и так, но тогда надо знать имена книг,
				//причем, после сохранения - знать расширение файла
				//excelappworkbook=excelappworkbooks["Книга 1"];
				//Запроса на сохранение для книги не должно быть
				excelappworkbook.Saved = true;
				// ФОрмат сохранения документа
				excelapp.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookNormal;
				// Сохраняем книгу
				try
				{
					// Определяем имя путь сохранения файла
					// Если каталог указан, проверяем его корректность и сохраняем файл
					// Если каталог не указан или не существует, сохраняем отчёт в папке с программой
					string saveFileName;
					if (Directory.Exists(Settings.Default.ReportDir) && Settings.Default.ReportDir != "")
					{
						saveFileName = Settings.Default.ReportDir + "\\Report " +
							DateTime.Now.ToShortDateString() + ".xls";
					}
					else
					{
						saveFileName = Application.StartupPath + "\\Report " +
							DateTime.Now.ToShortDateString() + ".xls";
					}

					//excelappworkbook.Save();
					excelappworkbook.SaveAs(saveFileName, Excel.XlFileFormat.xlWorkbookNormal);

					MessageBox.Show("Отчёт успешно сгенерирован и сохранён в файл: " + saveFileName, "Готово",
						MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка сохранения файла отчёта.",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					// Закрываем приложение
					excelapp.Quit();
					createReportButton.Enabled = true;
				}
				#endregion

				toolStripStatusLabel2.Text = "";

			} // End if DirectoryExists
			else
			{
				// Выводим сообщение, если каталог отчётов не указан
				MessageBox.Show("Каталог с файлами отчётов не найден!",
					"Ошибка открытия каталога.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void оПроToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Вывод окна "О Программе"
			About aboutForm = new About();
			aboutForm.ShowDialog();
		}

		private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Окно настроек программы
			SettingsForm settingsForm = new SettingsForm();
			settingsForm.ShowDialog();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			// Сохраняем каталог хранения отчётов
			if (DialogResult.OK == openReportDir.ShowDialog())
			{
				Settings.Default.ReportDir = openReportDir.SelectedPath;
				Settings.Default.Save();
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://alexbirukov.ru/?go=found/report/");
		}
	}
}

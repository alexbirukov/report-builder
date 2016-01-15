using System;
using System.Text;

namespace Report_Builder
{
	class Item
	{
		/// <summary>
		/// Знак предшествующей строке с песней.
		/// </summary>
		private string sign;
		
		public string Sign
		{
			get { return sign; }
			set { sign = value; }
		}
		/// <summary>
		/// Дата и время выхода песни в эфир.
		/// </summary>
		private DateTime date;

		public DateTime Date
		{
			get { return date; }
			set { date = value; }
		}
		/// <summary>
		/// Идентификатор песни в базе данных.
		/// </summary>
		private int dbId;

		public int DbId
		{
			get { return dbId; }
			set { dbId = value; }
		}
		/// <summary>
		/// Каталог верхнего уровня хранения файла.
		/// </summary>
		private string folder;

		public string Folder
		{
			get { return folder; }
			set { folder = value; }
		}
		/// <summary>
		/// Путь к файлу.
		/// </summary>
		private string path;

		public string Path
		{
			get { return path; }
			set { path = value; }
		}
		/// <summary>
		/// Продолжительность музыкального файла.
		/// </summary>
		private string duration;

		public string Duration
		{
			get { return duration; }
			set { duration = value; }
		}
		/// <summary>
		/// Полное название песни, включающее в себя имя исполнителя и название песни.
		/// </summary>
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		/// <summary>
		/// Название группы.
		/// </summary>
		private string group_name;

		public string Group_name
		{
			get { return group_name; }
			set { group_name = value; }
		}
		/// <summary>
		/// Название песни.
		/// </summary>
		private string song_name;

		public string Song_name
		{
			get { return song_name; }
			set { song_name = value; }
		}

	}
}

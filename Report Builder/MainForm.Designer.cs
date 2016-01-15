namespace Report_Builder
{
	partial class MainForm
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.browseButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.fileNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.createReportButton = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.openReportDir = new System.Windows.Forms.FolderBrowserDialog();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.настройкиToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(578, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Image = global::Report_Builder.Properties.Resources.application_exit;
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПроToolStripMenuItem});
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.справкаToolStripMenuItem.Text = "Справка";
			// 
			// оПроToolStripMenuItem
			// 
			this.оПроToolStripMenuItem.Image = global::Report_Builder.Properties.Resources.gnome_mime_text_x_credits;
			this.оПроToolStripMenuItem.Name = "оПроToolStripMenuItem";
			this.оПроToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.оПроToolStripMenuItem.Text = "О программе";
			this.оПроToolStripMenuItem.Click += new System.EventHandler(this.оПроToolStripMenuItem_Click);
			// 
			// настройкиToolStripMenuItem
			// 
			this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
			this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.настройкиToolStripMenuItem.Text = "Настройки";
			this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
			// 
			// openFolder
			// 
			this.openFolder.Description = "Укажите папку с файлами";
			this.openFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.browseButton);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.fileNameTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(554, 132);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Параметры";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(524, 100);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(24, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "...";
			this.toolTip1.SetToolTip(this.button1, "Укажите каталог в котором в котором будут сохраняться отчёты.");
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Report_Builder.Properties.Settings.Default, "ReportDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBox1.Location = new System.Drawing.Point(9, 102);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(509, 20);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = global::Report_Builder.Properties.Settings.Default.ReportDir;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Каталог сохранения отчёта:";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = global::Report_Builder.Properties.Settings.Default.AllFiles;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Report_Builder.Properties.Settings.Default, "AllFiles", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBox1.Location = new System.Drawing.Point(247, 60);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(202, 17);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Обрабатывать за указаный месяц";
			this.toolTip1.SetToolTip(this.checkBox1, "Если данная опция отключена, то будут обработаны \r\nвсе файлы с расширением .dpm.");
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(524, 30);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(24, 23);
			this.browseButton.TabIndex = 5;
			this.browseButton.Text = "...";
			this.toolTip1.SetToolTip(this.browseButton, "Указать расположение каталога с протоколами вещания формата \".dpm\"");
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Каталог протоколов вещания:";
			this.toolTip1.SetToolTip(this.label2, "Расположение файлов отчётов, прозвучавших в эфире треков.");
			// 
			// fileNameTextBox
			// 
			this.fileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Report_Builder.Properties.Settings.Default, "FilesDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.fileNameTextBox.Location = new System.Drawing.Point(9, 32);
			this.fileNameTextBox.Name = "fileNameTextBox";
			this.fileNameTextBox.ReadOnly = true;
			this.fileNameTextBox.Size = new System.Drawing.Size(509, 20);
			this.fileNameTextBox.TabIndex = 3;
			this.fileNameTextBox.Text = global::Report_Builder.Properties.Settings.Default.FilesDir;
			this.toolTip1.SetToolTip(this.fileNameTextBox, "Расположение файлов отчётов, прозвучавших в эфире треков.");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Отчётный месяц:";
			this.toolTip1.SetToolTip(this.label1, "Отчётный месяц, за который выбираются плейлисты.");
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Checked = false;
			this.dateTimePicker1.CustomFormat = "MMMM yyyy";
			this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Report_Builder.Properties.Settings.Default, "AllFiles", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Report_Builder.Properties.Settings.Default, "Month", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.dateTimePicker1.Enabled = global::Report_Builder.Properties.Settings.Default.AllFiles;
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(106, 58);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
			this.dateTimePicker1.TabIndex = 1;
			this.toolTip1.SetToolTip(this.dateTimePicker1, "Отчётный месяц, за который выбираются плейлисты.");
			this.dateTimePicker1.Value = global::Report_Builder.Properties.Settings.Default.Month;
			// 
			// createReportButton
			// 
			this.createReportButton.Image = global::Report_Builder.Properties.Resources.abiword;
			this.createReportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.createReportButton.Location = new System.Drawing.Point(462, 165);
			this.createReportButton.Name = "createReportButton";
			this.createReportButton.Size = new System.Drawing.Size(104, 23);
			this.createReportButton.TabIndex = 3;
			this.createReportButton.Text = "Создать отчёт";
			this.createReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip1.SetToolTip(this.createReportButton, "Формирование отчёта по трекам.");
			this.createReportButton.UseVisualStyleBackColor = true;
			this.createReportButton.Click += new System.EventHandler(this.createReportButton_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
			this.statusStrip1.Location = new System.Drawing.Point(0, 200);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(578, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
			this.toolStripStatusLabel1.Text = "Статус:";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.AutoSize = false;
			this.toolStripStatusLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(500, 17);
			this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(9, 175);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(104, 13);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "http://alexbirukov.ru";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 222);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.createReportButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Report Builder for Synadyn Broadcast";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		private System.Windows.Forms.FolderBrowserDialog openFolder;
		private System.Windows.Forms.ToolStripMenuItem оПроToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label1;
				private System.Windows.Forms.Button createReportButton;
				private System.Windows.Forms.ToolTip toolTip1;
				private System.Windows.Forms.StatusStrip statusStrip1;
				private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
				private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
				private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
				private System.Windows.Forms.CheckBox checkBox1;
				private System.Windows.Forms.Button button1;
				private System.Windows.Forms.TextBox textBox1;
				private System.Windows.Forms.Label label3;
				private System.Windows.Forms.FolderBrowserDialog openReportDir;
				private System.Windows.Forms.LinkLabel linkLabel1;
	}
}


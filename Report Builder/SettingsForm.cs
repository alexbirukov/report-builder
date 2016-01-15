using System;
using System.Resources;
using System.Windows.Forms;

namespace Report_Builder
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			// Получаем список псевдонимов
			string aliasesString = Properties.Settings.Default.Aliases;
			//string[] itemsString = aliasesString.Split(';');
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Properties.Settings.Default.Reload();
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Save();
			Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}
	}
}

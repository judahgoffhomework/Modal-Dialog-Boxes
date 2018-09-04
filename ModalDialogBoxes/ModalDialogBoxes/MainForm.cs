using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalDialogBoxes
{
	public partial class MainForm : Form
	{
		public static Settings s;
		public MainForm()
		{
			s = new Settings();
			InitializeComponent();
			setView();
			dropDown.Text = "";
		}

		private void setView()
		{
			CheckBox1.Visible = s.checkBox1;
			CheckBox2.Visible = s.checkBox2;
			CheckBox3.Visible = s.checkBox3;
			textBox.Text = s.textBox;
			dropDown.Text = s.dropdownList.ToString();
		}

		private void PopUpButton_Click(object sender, EventArgs e)
		{
			ModalDialogBox dialogBox = new ModalDialogBox();
			DialogResult result = dialogBox.ShowDialog();
			setView();
		}
	}
}

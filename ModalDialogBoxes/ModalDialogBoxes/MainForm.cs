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
		}

		private void PopUpButton_Click(object sender, EventArgs e)
		{
			ModalDialogBox dialogBox = new ModalDialogBox();
			DialogResult result = dialogBox.ShowDialog();
		}
	}
}

﻿using System;
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
	public partial class ModalDialogBox : Form
	{
		private Settings s;
		public ModalDialogBox()
		{
			InitializeComponent();

			s = MainForm.s;
			updateForm();
		}

		private void updateForm()
		{
			checkBox1.Checked = s.checkBox1;
			checkBox2.Checked = s.checkBox2;
			checkBox3.Checked = s.checkBox3;
			textBox.Text = s.textBox;
			dropdownList.SelectedItem = s.dropdownList.ToString();
		}

		private void ModalDialogBox_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.DialogResult == DialogResult.OK)
			{
				// Since OK was pressed, set the properties to the selected values
				updateCheckBox(checkBox1);
				updateCheckBox(checkBox2);
				updateCheckBox(checkBox3);
				if (textBox.Text != "") s.textBox = textBox.Text;
				if (dropdownList.SelectedItem != null)
				{
					s.dropdownList = this.getDropdownFromString(dropdownList.SelectedItem.ToString());
				}
			}
		}

		private DropDown getDropdownFromString(string s)
		{
			switch (s)
			{
				case "Item1":
					return DropDown.Item1;
				case "Item2":
					return DropDown.Item2;
				case "Item3":
					return DropDown.Item3;
				default:
					return DropDown.Item1;
			}
		}

		private void updateCheckBox(CheckBox checkbox)
		{
			switch (checkbox.Name)
			{
				case "checkBox1":
					s.checkBox1 = checkbox.Checked;
					break;
				case "checkBox2":
					s.checkBox2 = checkbox.Checked;
					break;
				case "checkBox3":
					s.checkBox3 = checkbox.Checked;
					break;
			}
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

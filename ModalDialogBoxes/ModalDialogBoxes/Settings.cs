using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModalDialogBoxes
{
	public class Settings
	{
		public bool[] checkBoxes { get; set; }
		public string textBox { get; set; }
		public DropDown dropdownList { get; set; }
		public Settings()
		{
			checkBoxes = new bool[] { false, false, false };
			textBox = "";
			dropdownList = DropDown.Item1;
		}
	}
}

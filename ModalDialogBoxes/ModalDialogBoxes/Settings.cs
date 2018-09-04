using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModalDialogBoxes
{
	public class Settings
	{
		public bool checkBox1 { get; set; }
		public bool checkBox2 { get; set; }
		public bool checkBox3 { get; set; }
		public string textBox { get; set; }
		public DropDown dropdownList { get; set; }
		public Settings()
		{
			checkBox1 = false;
			checkBox2 = false;
			checkBox3 = false;
			textBox = "";
			dropdownList = DropDown.Item1;
		}
	}
}

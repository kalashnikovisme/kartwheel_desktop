using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartwheel_Desktop {
	public static class ConnectAttributesController {
		static public void OpenDialogGetAttributes() {
			Program.MainForm.Visible = false;
			Program.MainForm = new Forms.ConnectForm();
			Program.MainForm.Show();			
		}
	}
}
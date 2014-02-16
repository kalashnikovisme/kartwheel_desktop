using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartwheel_Desktop {
	static public class MainController {
		static public void OpenDialogChooseDBMS() {
			Program.ChooseForm = new Forms.ChooseDBMSForm();
			Program.ChooseForm.Show();
		}
	}
}
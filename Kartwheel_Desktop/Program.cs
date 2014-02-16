using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartwheel_Desktop {
	static class Program {
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(MainForm = new Forms.ChooseDBMSForm());
		}
		internal static Kartwheel_Desktop.Forms.ConnectForm ConnectForm;
		internal static Kartwheel_Desktop.Forms.ChooseDBMSForm ChooseForm;
		internal static Form MainForm;
	}
}
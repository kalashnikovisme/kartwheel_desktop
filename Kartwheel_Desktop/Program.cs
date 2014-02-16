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
			MainForm = new Forms.ChooseDBMSForm();
			MainForm.FormClosing += MainForm_FormClosing;
			Application.Run(MainForm);
		}

		static void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
			Application.Exit();
		}
		internal static Kartwheel_Desktop.Forms.ConnectForm ConnectForm;
		internal static Kartwheel_Desktop.Forms.ChooseDBMSForm ChooseForm;
		internal static Form MainForm;
	}
}
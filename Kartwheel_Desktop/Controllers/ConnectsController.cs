using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kartwheel_Desktop.Controllers {
	public static class ConnectsController {
		static string DBMS_Name;
		static public void OpenDialogGetAttributes(string db_name) {
			DBMS_Name = db_name;
			Program.MainForm.Visible = false;
			Program.MainForm = new Forms.ConnectForm();
			Program.MainForm.Show();			
		}

		static public void ConnectToDatabase(string[] attributes) {
			string connectionString = "server=" + attributes[0] + ";database=" + attributes[1] + "";
			MySqlConnection connection = new MySqlConnection(connectionString);
			connection.Open();
		}
	}
}
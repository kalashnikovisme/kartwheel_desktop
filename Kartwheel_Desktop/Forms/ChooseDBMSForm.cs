using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartwheel_Desktop.Forms {
	public partial class ChooseDBMSForm : Form {
		public ChooseDBMSForm() {
			InitializeComponent();
			loadListOfDBMS_Adapters();
		}
		
		private void loadListOfDBMS_Adapters() {
			listBox.Items.AddRange(AppConfiguration.GetDBMS_AdaptersNames().ToArray());
		}

		private void button1_Click(object sender, EventArgs e) {
			ConnectAttributesController.OpenDialogGetAttributes();
		}
	}
}
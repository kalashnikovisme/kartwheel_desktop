using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
	}
}
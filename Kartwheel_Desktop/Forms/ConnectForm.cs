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
	public partial class ConnectForm : Form {
		public ConnectForm() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			List<string> attr = new List<string>();
			attr.Add(textBox1.Text);
			attr.Add(textBox2.Text);
			attr.Add(textBox3.Text);
			attr.Add(textBox4.Text);
			Controllers.ConnectsController.ConnectToDatabase(attr.ToArray());
		}
	}
}
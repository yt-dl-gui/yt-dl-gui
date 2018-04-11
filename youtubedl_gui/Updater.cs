using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtubedl_gui {
	public partial class Updater : Form {
		public Updater() {
			InitializeComponent();
		}

		private void Updater_Load(object sender, EventArgs e) {
			//0	check internet availability
			//1	check youtubedl binary exist
			//	1.1 if not -> 2.3
			//2	check youtubedl binary version
			//	2.1	show version number in label_info
			//	2.2	outdated version -> ask if update
			//		2.2.1	if no -> 3
			//		2.2.2	download youtubedl binary
			//3	check youtubedl binary checksum
			//4	all right, moving on.
		}
	}
}

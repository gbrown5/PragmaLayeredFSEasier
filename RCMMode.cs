using HandyStuff;
using PRAGMAsLayeredFSKit.Properties;
using System;
using System.Windows.Forms;

namespace PRAGMAsLayeredFSKit {
    public partial class RCMMode : Form {
        public RCMMode() {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e) {
            FileStuff.rcmSmash(Resources.hekate_ctcaer);
        }
        private void button2_Click(object sender, EventArgs e) {
            FileStuff.rcmSmash(Resources.biskeydump);
        }
    }
}
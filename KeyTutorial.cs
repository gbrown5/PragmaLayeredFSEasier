using System;
using System.Windows.Forms;

namespace PRAGMAsLayeredFSKit {
    public partial class KeyTutorial : Form {
        public KeyTutorial() {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e) {
            MessageBox.Show("I have yet to get this working with pure C#. Please follow this tutorial from Step 3 onwards: https://gbatemp.net/threads/506978, this will be automated in future versions.");
        }
        private void openRcmForm(object sender, EventArgs e) {
            new RCMMode().Show();
        }
    }
}
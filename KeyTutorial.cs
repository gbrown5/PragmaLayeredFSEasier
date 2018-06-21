using System;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;

namespace PRAGMAsLayeredFSKit {

    public partial class KeyTutorial : Form {

        //Python install directory.
        string PYTHON_DIR;

        public KeyTutorial() {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e) {
            run_py(AppDomain.CurrentDomain.BaseDirectory + "keys.py", txtSBK.Text + " " + txtTSEC.Text);
        }
        private void openRcmForm(object sender, EventArgs e) {
            new RCMMode().Show();
        }

        /*Will execute any py (I.E. keys.py) script with arguments*/
        private void run_py(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = PYTHON_DIR + "python.exe";
            start.Arguments = string.Format("{0} {1}", cmd, args);
            start.UseShellExecute = false;

            //Run the keys.py script
            Process process;
            int exitcode;
            using (process = Process.Start(start))
            {
                process.WaitForExit();
                exitcode = process.ExitCode;
            }

            if(exitcode == 0)
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Something went wrong. Ensure you have Python 2.7 and 'BOOT0' and 'BCPKG2-1-Normal-Main' are in the same directory.");
            }
        }

        /*Check if user has inputted keys*/
        private void checkKeys()
        {
            if (string.IsNullOrWhiteSpace(txtTSEC.Text) || string.IsNullOrWhiteSpace(txtSBK.Text))
            {
                btnExtractKeys.Enabled = false;
            }
            else
            {
                btnExtractKeys.Enabled = true;
            }

        }

        /*Check to make sure the keys are present before allowing
         * user to continue*/
        private void txtSBK_TextChanged(object sender, EventArgs e)
        {
            checkKeys();
        }

        private void txtTSEC_TextChanged(object sender, EventArgs e)
        {
            checkKeys();
        }

        /*Check for the prescense of keys and python installation*/
        private void KeyTutorial_Load(object sender, EventArgs e)
        {
            //If somehow the user already inputted the keys
            checkKeys();

            //Check for python 2.7 install directory
            PYTHON_DIR = FindPython();

            if(string.IsNullOrWhiteSpace(PYTHON_DIR))
            {
                PythonErr();
                this.Close();
            }
            
        }

        /*Reads the registry key for python 2.7 to get the correct path
           return: (string) Install directory of python 2.7*/
        private string FindPython()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Python\\PythonCore\\2.7\\InstallPath"))
                {
                    if (key != null)
                    {
                        Object o = key.GetValue("");
                        if (o != null)
                        {
                            return o.ToString();
                        }

                    }
                    //If didn't return, then error
                    PythonErr();
                }
            }
            catch (Exception ex)
            {
                PythonErr();
            }

            return "";
        }

        private void PythonErr()
        {
            if (MessageBox.Show("Please install Python 2.7", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.python.org/downloads/release/python-2715/");
            }
        }
    }
}
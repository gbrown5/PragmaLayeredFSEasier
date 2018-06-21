using PRAGMAsLayeredFSKit.Properties;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace HandyStuff {
    public class FileStuff {
        public static bool doesFileExist(string file) {
            if (!File.Exists(file)) {
                MessageBox.Show("The \"" + file + "\" file must be located next to this applications .exe file :)", "Where's " + file + "? :(");
                return false;
            }
            return true;
        }
        public static void extractHactool() {
            File.WriteAllBytes("hactool.exe", Resources.hactool);
            File.WriteAllBytes("libmbedcrypto.dll", Resources.libmbedcrypto);
            File.WriteAllBytes("libmbedtls.dll", Resources.libmbedtls);
            File.WriteAllBytes("libmbedx509.dll", Resources.libmbedx509);
        }
        public static void deleteHactool() {
            //File.Delete("hactool.exe");
            //File.Delete("libmbedcrypto.dll");
           // File.Delete("libmbedtls.dll");
            //File.Delete("libmbedx509.dll");
        }
        public static void rcmSmash(byte[] payload) {
            File.WriteAllBytes("rcmsmasher.exe", Resources.TegraRcmSmash);
            File.WriteAllBytes("payload.bin", payload);
            Process.Start("rcmsmasher.exe", "\"payload.bin\"").WaitForExit();
            File.Delete("rcmsmasher.exe");
            File.Delete("payload.bin");
        }
        public static void executeFile(string filename, string arguments=null) {
            Process.Start(filename, arguments).WaitForExit();
        }
    }
}

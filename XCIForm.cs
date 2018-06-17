using HandyStuff;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PRAGMAsLayeredFSKit
{
    public partial class XCIForm : Form {
        public XCIForm() {
            InitializeComponent();
        }
        private void XCIDecryptButton_Click(object sender, EventArgs e) {
            #region Verify Files and Donor TitleID
            if (!FileStuff.doesFileExist("keys.ini") || !FileStuff.doesFileExist("game.xci")) {
                return;
            }
            if (donorTitleId.Text == "0100XXXXXXXXXXX") {
                MessageBox.Show("You need to put a Donor Title ID!");
                return;
            }
            if (donorTitleId.Text.StartsWith("100")) {
                MessageBox.Show("The Donor Title ID needs to start with 0100.");
                return;
            }
            #endregion
            #region Extract Hactool
            FileStuff.extractHactool();
            #endregion
            #region Extract .NCA's
            Process.Start("hactool.exe", "-k keys.ini -txci --securedir=\"" + donorTitleId.Text + "\" \"game.xci\"").WaitForExit();
            #endregion
            #region Extract RomFS and ExeFS
            FileStuff.executeFile("hactool.exe", "-k keys.ini --romfs=\"" + donorTitleId.Text + "\\romfs.bin\" --exefsdir=\"" + donorTitleId.Text + "\\exefs\" \"" + donorTitleId.Text + "\\" + new DirectoryInfo(donorTitleId.Text).EnumerateFiles().OrderByDescending(f => f.Length).FirstOrDefault().Name + "\"");
            #endregion
            #region Delete hactool
            FileStuff.deleteHactool();
            #endregion
            #region Delete .NCA's
            foreach (string file in Directory.GetFiles(donorTitleId.Text, "*.nca")) {
                File.Delete(file);
            }
            #endregion
            #region Insert the new title id at offset 0x430 in ASIo

            #region Get the Title ID as bytes with hexadecimal base 16 and reverse it (little endian)
            byte[] titleBytes = new byte[8];
            MatchCollection mc = Regex.Matches(donorTitleId.Text, @"[a-fA-F0-9]{2}");
            for (int i = 0; i < 8; i++) {
                titleBytes[i] = Convert.ToByte(mc[i].Value, 16);
            }
            titleBytes = titleBytes.Reverse().ToArray();
            #endregion
            #region Write the new little endian hexadecimal base 16 hex values to the npdm
            using (FileStream source = File.OpenRead(donorTitleId.Text + "/exefs/main.npdm"))
            using (FileStream destination = File.OpenWrite(donorTitleId.Text + "/exefs/main.npdm.new")) {
                CopyTo(source, destination, 0x440);// first copy the data before insert
                new MemoryStream(titleBytes).CopyTo(destination);// write the new donor title id at 0x440 of size 0x8
                CopyTo(source, destination, (int)(source.Length - 0x440)); // copy remaining data
            }
            #endregion

            #endregion
            #region Delete the original npdm and overwrite it with the new edited npdm
            File.Delete(donorTitleId.Text + "/exefs/main.npdm");
            File.Move(donorTitleId.Text + "/exefs/main.npdm.new", donorTitleId.Text + "/exefs/main.npdm");
            #endregion
            MessageBox.Show(
                "The XCI is now decrypted. The folder was automatically renamed and the main.nmpd was automatically edited to contain the Donor TitleID!\n" +
                "Now just copy: " + donorTitleId.Text + " next to this applications .exe to sd:/atmosphere/titles/" + donorTitleId.Text + "\n" +
                "HAVE FUN! -PRAGMA"
            );
        }
        private static void CopyTo(Stream source, Stream destination, int count) {
            const int bufferSize = (32 * 1024);
            byte[] buffer = new byte[bufferSize];
            while (count > 0) {
                int actualRead = source.Read(buffer, 0, (count > bufferSize ? bufferSize : count));
                destination.Write(buffer, 0, actualRead);
                count -= actualRead;
            }
        }
    }
}
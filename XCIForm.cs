using HandyStuff;
using System;
using System.Collections.Generic;
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
                byte[] patchedNpdm = patchTitleId(File.ReadAllBytes(donorTitleId.Text + "/exefs/main.npdm"), titleBytes);
                destination.Write(patchedNpdm, 0, patchedNpdm.Length);
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
        private static byte[] patchTitleId(byte[] source, byte[] titleBytes, int offset=0) {
            //Get to the next 0x41 byte (A)
            while (source[offset] != 0x41) {
                offset++;
            }
            //Loop if the next HEX bytes arent: 43 49 30 (CI0)
            //These are seperate if's to accomodate offset so its exactly 1 index off from what it just tried, so it doesnt just match 0 on re-loop
            if (source[++offset] != 0x43) {
                return patchTitleId(source, titleBytes, offset);
            }
            if (source[++offset] != 0x49) {
                return patchTitleId(source, titleBytes, offset);
            }
            if (source[++offset] != 0x30) {
                return patchTitleId(source, titleBytes, offset);
            }
            //Check if the next 12 bytes are 0x00
            for (int i = 0; i < 12; i++) {
                ++offset;
                if (source[offset] != 0x00) {
                    return patchTitleId(source, titleBytes, (offset - (i+1))); //reloop
                }
            }
            //We are now at the end of ASIC0............
            //Now just overwrite the next 8 indexes (current titleid) with the new titleid bytes
            for (int i = 1; i <= 8; i++) {
                source[(offset + i)] = titleBytes[i-1];
            }
            //return the patched source
            return source;
        }
    }
}
namespace PRAGMAsLayeredFSKit
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Install Hekate-IPL, CTCaer Hekate Mod w/ LFS Support";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sdfilesmodbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(365, 33);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "You need to get the proper SD Files with LayeredFS support before continuing, use" +
    " the button below.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(365, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Get Keys.ini aswell as BOOT0 and BCPKG2-1-Normal-Main";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OpenKeyTutorialButton_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 80);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(365, 33);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "You also need to get your Switch\'s Keys.ini and BCPKG2-1-Normal-Main so we can pa" +
    "tch your kernel for LayeredFS Support and decrypt xci and ncas.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(364, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Trim, Extract, Decrypt and Patch kernel.bin from BCPKG2-1-Normal-Main";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PatchKernelButton_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(13, 178);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(364, 40);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "You now have full LayeredFS support. All you need now is to setup decrypted .XCI " +
    "titleid folders for backup loading :O";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(364, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = ".XCI Decrypter and .npdm editor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OpenXCIDecrypterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 263);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "PRAGMA\'s LFS Kit v1.2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button4;
    }
}


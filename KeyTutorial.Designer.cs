namespace PRAGMAsLayeredFSKit
{
    partial class KeyTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyTutorial));
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnExtractKeys = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.txtSBK = new System.Windows.Forms.TextBox();
            this.txtTSEC = new System.Windows.Forms.TextBox();
            this.lblSBK = new System.Windows.Forms.Label();
            this.lblTSEC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Smash Biskeydump";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.openRcmForm);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(364, 87);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(364, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Smash Hekate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.openRcmForm);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(13, 167);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(364, 171);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // btnExtractKeys
            // 
            this.btnExtractKeys.Location = new System.Drawing.Point(10, 392);
            this.btnExtractKeys.Name = "btnExtractKeys";
            this.btnExtractKeys.Size = new System.Drawing.Size(364, 23);
            this.btnExtractKeys.TabIndex = 4;
            this.btnExtractKeys.Text = "Extract Keys from BOOT0 and BCPKG2-1-Normal-Main";
            this.btnExtractKeys.UseVisualStyleBackColor = true;
            this.btnExtractKeys.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(11, 421);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(364, 22);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "You should now have a \"keys.ini\" file, your now ready to continue.";
            // 
            // txtSBK
            // 
            this.txtSBK.Location = new System.Drawing.Point(117, 344);
            this.txtSBK.Name = "txtSBK";
            this.txtSBK.Size = new System.Drawing.Size(206, 20);
            this.txtSBK.TabIndex = 6;
            this.txtSBK.TextChanged += new System.EventHandler(this.txtSBK_TextChanged);
            // 
            // txtTSEC
            // 
            this.txtTSEC.Location = new System.Drawing.Point(117, 366);
            this.txtTSEC.Name = "txtTSEC";
            this.txtTSEC.Size = new System.Drawing.Size(206, 20);
            this.txtTSEC.TabIndex = 7;
            this.txtTSEC.TextChanged += new System.EventHandler(this.txtTSEC_TextChanged);
            // 
            // lblSBK
            // 
            this.lblSBK.AutoSize = true;
            this.lblSBK.Location = new System.Drawing.Point(50, 347);
            this.lblSBK.Name = "lblSBK";
            this.lblSBK.Size = new System.Drawing.Size(52, 13);
            this.lblSBK.TabIndex = 8;
            this.lblSBK.Text = "SBK Key:";
            // 
            // lblTSEC
            // 
            this.lblTSEC.AutoSize = true;
            this.lblTSEC.Location = new System.Drawing.Point(50, 369);
            this.lblTSEC.Name = "lblTSEC";
            this.lblTSEC.Size = new System.Drawing.Size(59, 13);
            this.lblTSEC.TabIndex = 9;
            this.lblTSEC.Text = "TSEC Key:";
            // 
            // KeyTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 453);
            this.Controls.Add(this.lblTSEC);
            this.Controls.Add(this.lblSBK);
            this.Controls.Add(this.txtTSEC);
            this.Controls.Add(this.txtSBK);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.btnExtractKeys);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "KeyTutorial";
            this.Text = "Key Dumping";
            this.Load += new System.EventHandler(this.KeyTutorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnExtractKeys;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox txtSBK;
        private System.Windows.Forms.TextBox txtTSEC;
        private System.Windows.Forms.Label lblSBK;
        private System.Windows.Forms.Label lblTSEC;
    }
}
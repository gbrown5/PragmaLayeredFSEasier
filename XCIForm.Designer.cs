namespace PRAGMAsLayeredFSKit
{
    partial class XCIForm
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
            this.donorTitleId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // donorTitleId
            // 
            this.donorTitleId.Location = new System.Drawing.Point(12, 47);
            this.donorTitleId.Name = "donorTitleId";
            this.donorTitleId.Size = new System.Drawing.Size(399, 20);
            this.donorTitleId.TabIndex = 0;
            this.donorTitleId.Text = "0100XXXXXXXXXXX";
            this.donorTitleId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Donor\'s TitleID\r\nCan be obtained at: nswdb.com and/or google";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(399, 86);
            this.button1.TabIndex = 2;
            this.button1.Text = "DECRYPT XCI\r\n- by @PRAGMA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.XCIDecryptButton_Click);
            // 
            // XCIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 173);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.donorTitleId);
            this.Name = "XCIForm";
            this.Text = "XCI Decrypter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox donorTitleId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
namespace tjdamiblockchainclientdemo
{
    partial class FrmShowPic
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowPic));
            this.webpic = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webpic
            // 
            this.webpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webpic.Location = new System.Drawing.Point(0, 0);
            this.webpic.MinimumSize = new System.Drawing.Size(20, 20);
            this.webpic.Name = "webpic";
            this.webpic.Size = new System.Drawing.Size(861, 547);
            this.webpic.TabIndex = 0;
            // 
            // FrmShowPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 547);
            this.Controls.Add(this.webpic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmShowPic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmShowPic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webpic;

    }
}
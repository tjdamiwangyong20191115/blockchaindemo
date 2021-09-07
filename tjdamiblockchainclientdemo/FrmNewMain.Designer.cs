namespace tjdamiblockchainclientdemo
{
    partial class FrmNewMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewMain));
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblFilepathinserver = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabBin = new System.Windows.Forms.TabPage();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.tabText = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSource = new System.Windows.Forms.TabPage();
            this.txtSourceCID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPrivatekey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.txtPrivatekeyMD5 = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.tabBin.SuspendLayout();
            this.tabText.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(125, 39);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(240, 21);
            this.txtAccount.TabIndex = 25;
            this.txtAccount.Text = "wqq";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(37, 380);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(750, 194);
            this.txtResult.TabIndex = 23;
            // 
            // lblFilepathinserver
            // 
            this.lblFilepathinserver.AutoSize = true;
            this.lblFilepathinserver.Location = new System.Drawing.Point(109, 100);
            this.lblFilepathinserver.Name = "lblFilepathinserver";
            this.lblFilepathinserver.Size = new System.Drawing.Size(0, 12);
            this.lblFilepathinserver.TabIndex = 8;
            this.lblFilepathinserver.DoubleClick += new System.EventHandler(this.lblFilepathinserver_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "File in server:";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(3, 55);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(113, 23);
            this.btnUploadFile.TabIndex = 6;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "File:";
            // 
            // tabBin
            // 
            this.tabBin.Controls.Add(this.lblFilepathinserver);
            this.tabBin.Controls.Add(this.label5);
            this.tabBin.Controls.Add(this.btnUploadFile);
            this.tabBin.Controls.Add(this.label4);
            this.tabBin.Controls.Add(this.txtfile);
            this.tabBin.Location = new System.Drawing.Point(4, 22);
            this.tabBin.Name = "tabBin";
            this.tabBin.Padding = new System.Windows.Forms.Padding(3);
            this.tabBin.Size = new System.Drawing.Size(749, 142);
            this.tabBin.TabIndex = 1;
            this.tabBin.Text = "Binary";
            this.tabBin.UseVisualStyleBackColor = true;
            // 
            // txtfile
            // 
            this.txtfile.AllowDrop = true;
            this.txtfile.Location = new System.Drawing.Point(3, 28);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(743, 21);
            this.txtfile.TabIndex = 4;
            this.txtfile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtfile_DragDrop);
            this.txtfile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtfile_DragEnter);
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(3, 3);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(743, 136);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = "{\r\n\"key\":\"sadfsdfdf\"\r\n}";
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.txtContent);
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3);
            this.tabText.Size = new System.Drawing.Size(749, 142);
            this.tabText.TabIndex = 0;
            this.tabText.Text = "Text";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "Account";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabText);
            this.tabControl1.Controls.Add(this.tabBin);
            this.tabControl1.Controls.Add(this.tabSource);
            this.tabControl1.Location = new System.Drawing.Point(37, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 168);
            this.tabControl1.TabIndex = 22;
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.txtSourceCID);
            this.tabSource.Controls.Add(this.label7);
            this.tabSource.Controls.Add(this.txtSource);
            this.tabSource.Location = new System.Drawing.Point(4, 22);
            this.tabSource.Name = "tabSource";
            this.tabSource.Size = new System.Drawing.Size(749, 142);
            this.tabSource.TabIndex = 2;
            this.tabSource.Text = "Source";
            this.tabSource.UseVisualStyleBackColor = true;
            // 
            // txtSourceCID
            // 
            this.txtSourceCID.Location = new System.Drawing.Point(76, 8);
            this.txtSourceCID.Name = "txtSourceCID";
            this.txtSourceCID.Size = new System.Drawing.Size(670, 21);
            this.txtSourceCID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Source CID";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(3, 32);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(746, 107);
            this.txtSource.TabIndex = 0;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(87, 309);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(700, 21);
            this.txtCid.TabIndex = 20;
            this.txtCid.Text = "NAJTXT31ZWH7UHD7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "CID";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(37, 270);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 18;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(37, 350);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 21;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(125, 11);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(662, 21);
            this.txtIP.TabIndex = 17;
            this.txtIP.Text = "http://114.116.96.237:19630";
            // 
            // txtPrivatekey
            // 
            this.txtPrivatekey.Location = new System.Drawing.Point(125, 69);
            this.txtPrivatekey.Name = "txtPrivatekey";
            this.txtPrivatekey.Size = new System.Drawing.Size(240, 21);
            this.txtPrivatekey.TabIndex = 16;
            this.txtPrivatekey.Text = "EFiMmLjenIyM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "IP:Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "private key";
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(372, 67);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(66, 23);
            this.btnMD5.TabIndex = 27;
            this.btnMD5.Text = "MD5";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // txtPrivatekeyMD5
            // 
            this.txtPrivatekeyMD5.Location = new System.Drawing.Point(445, 67);
            this.txtPrivatekeyMD5.Name = "txtPrivatekeyMD5";
            this.txtPrivatekeyMD5.Size = new System.Drawing.Size(342, 21);
            this.txtPrivatekeyMD5.TabIndex = 28;
            this.txtPrivatekeyMD5.Text = "698cd18c60eff5618431bd1dea0bb0a2";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(118, 350);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 29;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FrmNewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 590);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtPrivatekeyMD5);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtPrivatekey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmNewMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yunchuan BlockChain Client Demo";
            this.tabBin.ResumeLayout(false);
            this.tabBin.PerformLayout();
            this.tabText.ResumeLayout(false);
            this.tabText.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.tabSource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblFilepathinserver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabBin;
        private System.Windows.Forms.TextBox txtfile;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPrivatekey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.TextBox txtPrivatekeyMD5;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtSourceCID;
        private System.Windows.Forms.Label label7;
    }
}

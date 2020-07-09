using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace tjdamiblockchainclientdemo
{
    public partial class FrmShowPic : Form
    {
        public string strfilename = "";
        public FrmShowPic()
        {
            InitializeComponent();
        }

        private void FrmShowPic_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strfilename))
            {
                this.Text = strfilename;
                webpic.Navigate(strfilename);                
            }            
        }
    }
}

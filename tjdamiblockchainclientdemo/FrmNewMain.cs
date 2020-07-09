using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace tjdamiblockchainclientdemo
{
    public partial class FrmNewMain : Form
    {
        public FrmNewMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContent.Text))
            {
                return;
            }
            string strpost = "";
            string strRet = "";

            if (tabControl1.SelectedTab.Text.Equals("Text"))
            {
                //上传文字信息
                strpost = txtContent.Text;
                strRet = HttpUtil.HttpPost(txtIP.Text + "/blockchain-generic/TraceabilityController/saveData", strpost, "");
            }
            else
            {
                //上传文件信息
                strpost = "{\"account\": \"" + txtAccount.Text + "\",\"evidencedata\": {\"fileurl\":\"" + lblFilepathinserver.Text + "\"},\"sign\": \"" + txtPrivatekeyMD5.Text + "\"}";
                strRet = HttpUtil.HttpPost(txtIP.Text + "/blockchain-generic/TraceabilityController/savefile", strpost, "");
            }

            txtResult.Text = strRet.Replace("\\\"", "\"");

        }

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCid.Text))
            {
                return;
            }
            string strpost = "{\"account\": \"" + txtAccount.Text + "\",\"idhash\": \"" + txtCid.Text + "\"}";
            string strRet = HttpUtil.HttpPost(txtIP.Text + "/blockchain-generic/TraceabilityController/findData", strpost, "");
            txtResult.Text = strRet.Replace("\\\"", "\"");
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            txtPrivatekeyMD5.Text = clsMD5.getmd5(txtPrivatekey.Text);
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            lblFilepathinserver.Text = "";

            string strjson = HttpUtil.Upload(txtIP.Text + "/upload/upload", txtfile.Text);
            string strcode = JsonHepler.getvaluefromjson(strjson, "code");
            if (string.IsNullOrEmpty(strcode) || !strcode.Equals("0"))
            {
                lblFilepathinserver.Text = strjson;
            }
            else
            {
                string strvalue = JsonHepler.getvaluefromjson(strjson, "value");
                if (string.IsNullOrEmpty(strvalue))
                {
                    lblFilepathinserver.Text = strjson;
                }
                else
                {
                    lblFilepathinserver.Text = strvalue;
                }
            }
        }

        private void txtfile_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (filePath != null && filePath.Length == 1)
            {
                TextBox t = (TextBox)sender;
                t.Text = filePath[0];
            }
        }

        private void txtfile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void lblFilepathinserver_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(lblFilepathinserver.Text);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FrmShowPic frm = new FrmShowPic();
            frm.strfilename = lblFilepathinserver.Text;
            frm.ShowDialog();
        }
    }
}

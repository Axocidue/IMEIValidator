using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IMEIValidator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            var digits = tbx_IMEI.Text.Trim();

            if(!digits.IsDigits())
            {
                tbx_Result.Text = "Validation Failed!\r\nInvalid String Format!";
                return;
            }

            if(!digits.IsIMEI())
            {
                var imei = digits.Substring(0, 14).GetIMEI15();
                tbx_Result.Text = "Validation Failed!\r\nInvalid IMEI Number!\r\nThe correct IMEI should be " + imei;
                return;
            }
            else
            {
                tbx_Result.Text = "Validation Passed!\r\nValid IMEI Number!";
                return;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //var imei14s = File.ReadAllLines(@"C:\Lemon\Personal\Desktop\source.txt", Encoding.Default);
            //var imei15s = (from imei14 in imei14s
            //              select imei14.GetIMEI15()).ToArray();
            //File.WriteAllLines(@"C:\Lemon\Personal\Desktop\results.txt", imei15s, Encoding.Default);
        }
    }
}

using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResumeApplication
{
    public partial class mainForm : MetroSetForm
    {

        private static string encrypt_key = "eerj3glTDu6AFI75iyoXI7cjSwAuXri9";
        private string newtext;

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            name_Label.ForeColor = Color.White;
            price_Label.ForeColor = Color.White;
            identifier_Label.ForeColor = Color.White;
            quantity_Label.ForeColor = Color.White;
            description_Label.ForeColor = Color.White;

        }

        private void encrypt()
        {
            this.newtext = metroSetTextBox1.Text;
            var encryptionString = Encryption.EncryptString(encrypt_key, this.newtext);
            var decryptString = Encryption.DecryptString(encrypt_key, encryptionString);

            metroSetTextBox1.Multiline = true;
            metroSetTextBox1.Text = "";
            metroSetTextBox1.AppendText($"Encrypted String: {encryptionString}");
            metroSetTextBox1.AppendText(Environment.NewLine);
            metroSetTextBox1.AppendText($"Decrypted String: {decryptString}");

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            encrypt();
            metroSetTextBox1.ReadOnly = true;
        }
    }

}

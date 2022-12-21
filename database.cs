using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementsSystem
{

    public partial class db_main : MetroSetForm
    {
        private string server;
        private string username;
        private string password;
        private string dbname;
        private bool firstTime1 = true;
        private bool firstTime2 = true;
        private bool firstTime3 = true;
        private bool firstTime4 = true;
        private static string encrypt_key = "eerj3glTDu6AFI75iyoXI7cjSwAuXri9";

        public db_main()
        {
            InitializeComponent();
        }

        private void database_Load(object sender, EventArgs e)
        {

        }

        private void user_text_Enter(object sender, EventArgs e)
        {
            if (firstTime1 == true)
            {
                user_text.Text = String.Empty;
            }

             firstTime1 = false;
        }

        private void server_text_Enter(object sender, EventArgs e)
        {
            if (firstTime2 == true)
            {
                server_text.Text = String.Empty;
            }

             firstTime2 = false;
            
        }

        private void pass_text_Enter(object sender, EventArgs e)
        {

            if (firstTime3 == true)
            {
                pass_text.Text = String.Empty;
            }

            firstTime3 = false;
        }

        private void db_text_Enter(object sender, EventArgs e)
        {

            if (firstTime4 == true)
            {
                db_text.Text = String.Empty;
            }

            firstTime4 = false;
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            this.server = server_text.Text;
            this.username = user_text.Text;
            this.password = pass_text.Text;
            this.dbname = db_text.Text;

            string serverenc = Encryption.EncryptString(encrypt_key, server);
            string userenc = Encryption.EncryptString(encrypt_key, username);
            string passenc = Encryption.EncryptString(encrypt_key, password);
            string dbenc = Encryption.EncryptString(encrypt_key, dbname);


            using (StreamWriter write = File.AppendText(@"db_list.txt"))
            {
                string writer = ($"DATABASE LIST: {Environment.NewLine}{serverenc} {Environment.NewLine}{userenc} {Environment.NewLine}{passenc} {Environment.NewLine}{dbenc}");
                write.WriteLine(writer);
                write.Close();
            }
        }
    }
}

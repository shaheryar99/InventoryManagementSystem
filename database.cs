using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private string friendly_name;
        private bool firstTime1 = true;
        private bool firstTime2 = true;
        private bool firstTime3 = true;
        private bool firstTime4 = true;
        private bool firstTime5 = true;

        public db_main()
        {
            InitializeComponent();
        }

        private void database_Load(object sender, EventArgs e)
        {
            server_text.Text = "Enter Server";
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
            Globals global = new Globals();
            int error = 0;
            this.server = server_text.Text;
            global.server = server;
            this.username = user_text.Text;
            global.username = username;
            this.password = pass_text.Text;
            global.password = password;
            this.dbname = db_text.Text;
            global.db_name = dbname;
            this.friendly_name = fname_text.Text;

            if (server == "Enter Server" || server == String.Empty)
            {
                error_msg("Server");
                error = 1;
            }
            if (username == "Enter Username" || username == String.Empty)
            {
                error_msg("Username");
                error = 1;
            }
            if (password == "Enter Password" || password == String.Empty)
            {
                error_msg("Password");
                error = 1;
            }
            if (dbname == "Enter a DB Name" || dbname == String.Empty)
            {
                error_msg("Database Name");
                error = 1;
            }
            if (friendly_name == "Enter a Friendly Name" || friendly_name == String.Empty)
            {
                error_msg("Friendly Name");
                error = 1;
            }

            if (error != 1)
            {
                string serverenc = Encryption.EncryptString(Globals.encrypt_key, server);
                string userenc = Encryption.EncryptString(Globals.encrypt_key, username);
                string passenc = Encryption.EncryptString(Globals.encrypt_key, password);
                string dbenc = Encryption.EncryptString(Globals.encrypt_key, dbname);  


                using (StreamWriter write = File.AppendText(Globals.dbfile))
                {
                    string writer = ($"DATABASE: {Environment.NewLine}{serverenc} {Environment.NewLine}{userenc} {Environment.NewLine}{passenc} {Environment.NewLine}{dbenc} {Environment.NewLine}{friendly_name}");
                    write.WriteLine(writer);
                    write.Close();
                }
            }

            DBConnection db = new DBConnection();
            //Debug.WriteLine(db.connector(server, username, password, dbname, "test"));
            db.connector(server, username, password, dbname, "test");
            if (db.isConnected == true)
            {

                this.Visible = false;
                mainForm main = new mainForm();
                main.globalUpdater(server, username, password, dbname);
                main.Visible = true;
                //main.ShowDialog();
            }
        }

        private void metroSetTextBox1_Enter(object sender, EventArgs e)
        {
            if (firstTime5 == true)
            {
                fname_text.Text = String.Empty;
            }

            firstTime5 = false;
        }

        private void error_msg(String txt)
        {
            MessageBox.Show($"The {txt} field is empty.", "Error");
        }
    }
}

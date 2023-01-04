using MetroSet_UI.Forms;
using System;
using System.Collections;
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
    public partial class Dbexists : MetroSetForm
    {
        private string dbfile = Globals.dbfile;
        private string dbselected;
        private string[] fulldbList;
        private string username;
        private string password;
        private string server;
        private string dbvar;

        public Dbexists()
        {
            InitializeComponent();
        }

        private void Dbexists_Load(object sender, EventArgs e)
        {

            this.fulldbList = File.ReadAllLines(dbfile);

            for(int i = 5; i < fulldbList.Length; i+=6)
            {
                this.dblist_box.Items.Add(fulldbList[i]);
            }

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form dbmain = new db_main();
            dbmain.ShowDialog();
        }

        private void dblist_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dbselected = dblist_box.Text;
            int dbindex = Array.FindIndex(fulldbList, db => db.Contains(dbselected));
            dbvar = Encryption.DecryptString(Globals.encrypt_key, fulldbList[dbindex - 1]);
            password = Encryption.DecryptString(Globals.encrypt_key, fulldbList[dbindex - 2]);
            username = Encryption.DecryptString(Globals.encrypt_key, fulldbList[dbindex - 3]);
            server = Encryption.DecryptString(Globals.encrypt_key, fulldbList[dbindex - 4]);

            Debug.WriteLine($"Database: {dbvar}, User: {username}, Password: {password}, Server: {server}");
        }

        private void removedb_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form RemoveDB = new RemoveDB();
            RemoveDB.ShowDialog();

        }
    }
}

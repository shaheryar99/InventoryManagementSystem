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
using System.Diagnostics;

namespace InventoryManagementsSystem
{
    public partial class RemoveDB : MetroSetForm
    {
        private string dbfile = Globals.dbfile;
        private string[] fulldbList;

        public RemoveDB()
        {
            InitializeComponent();
        }

        private void RemoveDB_Load(object sender, EventArgs e)
        {
            this.fulldbList = File.ReadAllLines(dbfile);

            for (int i = 5; i < fulldbList.Length; i += 6)
            {
                this.dblist_box.Items.Add(fulldbList[i]);
            }
        }

        private void removedb_btn_Click(object sender, EventArgs e)
        {
            string dbselected;
            dbselected = dblist_box.Text;
            int dbindex = Array.FindIndex(fulldbList, db => db.Contains(dbselected));
            List<string> newlist = new List<string>(fulldbList);

            for (int i = 0; i <= 5; i++)
            {
                newlist.RemoveAt(dbindex - i);
                
            }

            File.Delete(Globals.dbfile);

            using (StreamWriter write = File.AppendText(Globals.dbfile))
            {
                foreach (string line in newlist)
                {
                    write.WriteLine(line);
                }
                write.Close();
            }

            this.Visible = false;
            Form Dbexists = new Dbexists();
            Dbexists.ShowDialog();
        }
    }
}

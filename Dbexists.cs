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
        private ArrayList dbList = new ArrayList();
        static readonly string dbfile = @"db_list.txt";

        public Dbexists()
        {
            InitializeComponent();
        }

        private void Dbexists_Load(object sender, EventArgs e)
        {

            string [] fulldbList = File.ReadAllLines(dbfile);

            for(int i = 5; i < fulldbList.Length; i+=6)
            {
                this.dbList.Add(fulldbList[i]);
            }
            for(int i = 0; i < dbList.Count; i++)
            {
                dblist_box.Items.Add(dbList[i]);
            }

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form dbmain = new db_main();
            dbmain.ShowDialog();
        }
    }
}

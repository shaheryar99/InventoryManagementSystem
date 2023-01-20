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

namespace InventoryManagementsSystem
{
    public partial class mainForm : MetroSetForm
    {

        private string newtext;
        private Globals global = new Globals();

        public mainForm()
        {
            InitializeComponent();
        }

        public void globalUpdater(string server, string username, string password, string database)
        {
            global.server = server;
            global.username = username;
            global.password = password;
            global.db_name = database;
        }
        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -1;
            }
        }
        private void resizeForm()
        {
            int width = 0;
            foreach (ColumnHeader column in ListViewer.Columns)
            {
                width = column.Width;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            /**name_Label.ForeColor = Color.White;
            price_Label.ForeColor = Color.White;
            identifier_Label.ForeColor = Color.White;
            quantity_Label.ForeColor = Color.White;
            description_Label.ForeColor = Color.White; **/
            ListViewer.Columns.Clear();
            ListViewer.Columns.Add("Server:", 250);
            ListViewer.Columns.Add("Username:", 250);
            ListViewer.Columns.Add("Password", 250);
            ListViewer.Columns.Add("DB Name:", 250);

            ListViewer.Items.Add($"{global.server}");
            
            ListViewer.Items.Add($"{global.username}");
            ListViewer.Items.Add($"{global.password}");
            ListViewer.Items.Add($"{global.db_name}");
            ResizeListViewColumns(ListViewer);
            resizeForm();

            /** Does not resize properly here **/
        }

    }

}

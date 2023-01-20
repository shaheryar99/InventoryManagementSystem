using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementsSystem
{
    class Globals
    {
        public static readonly string dbfile = @"db_list.txt";
        public static readonly string encrypt_key = "eerj3glTDu6AFI75iyoXI7cjSwAuXri9";
        public string username { get; set; }
        public string password { get; set; }
        public string db_name { get; set; }
        public string server { get; set; }

    }
}

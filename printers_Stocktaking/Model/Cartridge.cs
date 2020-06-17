using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printers_Stocktaking.Model
{
    class Cartridge
    {
        public int ID { get; private set; }
        public string InventoryNum { get; set; }

        public Cartridge() { }
        public Cartridge(int id, string inv_num) : this() {
            ID = id;
            InventoryNum = inv_num;
        }
    }
}

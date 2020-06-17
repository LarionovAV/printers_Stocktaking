using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printers_Stocktaking.Model
{
    class PrinterStatement
    {
        public int ID { get; private set; }
        public string Name { get; set; }

        public PrinterStatement() { }
        public PrinterStatement(string name) {
            Name = name;
        }
        public PrinterStatement(int id, string name) : this(name) {
            ID = id;
        }
    }
}

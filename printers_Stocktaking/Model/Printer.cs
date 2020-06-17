using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printers_Stocktaking.Model
{
    class Printer : IDbEntity
    {
        public int ID { get; private set; }
        public string InventoryNum { get; set; }
        public string SerialNum { get; set; }
        public PrinterType PrinterType { get; set; }
        public PrinterModel PrinterModel { get; set; }
        public Creator Creator { get; set; }
        
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}

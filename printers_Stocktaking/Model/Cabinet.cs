using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printers_Stocktaking.Model
{
    class Cabinet : IDbEntity
    {
        public int ID{ get; private set; }
        public Department Department { get; set; }
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}

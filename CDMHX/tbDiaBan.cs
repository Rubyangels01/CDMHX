using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
   public class tbDiaBan
    {
        public string MaDB { get; set; }
        public string TenDB { get; set; }
        public tbDiaBan(string MaDB, string TenDB)
        {
            this.MaDB = MaDB;
            this.TenDB = TenDB;
        }
    }
}

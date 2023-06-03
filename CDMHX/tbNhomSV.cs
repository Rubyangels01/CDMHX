using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class tbNhomSV
    {
        public int MaNhom { get; set; }
        public string TenNhom { get; set; }
        public int Soluong { get; set; }
       public tbChienDich chiendich { get; set; }

        public tbNhomSV()
        {
            chiendich = new tbChienDich();
        }


    }
}

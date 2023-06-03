using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class tbThanhVienNhom
    {
       public tbSinhVien sv { get; set; }
       public  tbNhomSV nhom { get; set; }
        public string ChucVu { get; set; }
        public tbThanhVienNhom()
        {
            sv = new tbSinhVien();
            nhom = new tbNhomSV();
           
        }
    }
}

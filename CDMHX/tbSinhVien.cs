using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class tbSinhVien
    {
        public int MaSV { get; set; }
        public string TenSV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }

        public tbKhoa Khoa { get; set; }

        public tbSinhVien()
        {
            Khoa = new tbKhoa();
        }
        
    }
}

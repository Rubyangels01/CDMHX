using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class tbGiaoVien
    {
        public int MaGV { get; set; }
        public string TenGV { get; set; }
        public tbKhoa Khoa { get; set; }

        public tbGiaoVien()
        {
            Khoa = new tbKhoa();
        }
    }

}

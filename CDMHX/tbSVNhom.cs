using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class tbSVNhom
    {
        public int masv { get; set; }
        public string tensv { get; set; }
        public string nhom { get; set; }
        public tbSVNhom(int masv, string tensv, string nhom)
        {
            this.masv = masv;
            this.tensv = tensv;
            this.nhom = nhom;
        }
    }
}

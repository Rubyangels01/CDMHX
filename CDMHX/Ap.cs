using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    public class Ap
    {
        public string MaAp { get; set; }
        public string TenAp { get; set; }
        public Ap(string MaAp , string TenAp)
        {
            this.MaAp = MaAp;
            this.TenAp = TenAp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlygara
{
    class DichVu
    {
        private String madichvu;
        private String tendichvu;
        private double giadichvu;

        public DichVu()
        {
        }

        public DichVu(string madichvu, string tendichvu, double giadichvu)
        {
            this.madichvu = madichvu;
            this.tendichvu = tendichvu;
            this.giadichvu = giadichvu;
        }

        public string Madichvu { get => madichvu; set => madichvu = value; }
        public string Tendichvu { get => tendichvu; set => tendichvu = value; }
        public double Giadichvu { get => giadichvu; set => giadichvu = value; }
    }
}

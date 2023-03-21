using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlygara
{
    class HoaDon
    {
        private string mamathang;
        private string tenmathang;
        private double dongianhap;
        private int soluong;
        private double thanhtien;

        public HoaDon()
        {
        }

        public HoaDon(string mamathang, string tenmathang, double dongianhap, int soluong, double thanhtien)
        {
            Mamathang = mamathang;
            Tenmathang = tenmathang;
            Dongianhap = dongianhap;
            Soluong = soluong;
            Thanhtien = thanhtien;
        }

        public string Mamathang { get => mamathang; set => mamathang = value; }
        public string Tenmathang { get => tenmathang; set => tenmathang = value; }
        public double Dongianhap { get => dongianhap; set => dongianhap = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Thanhtien { get => thanhtien; set => thanhtien = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}

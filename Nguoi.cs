using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Nguoi
    {
        protected string CMND;
        protected string Ten;
        protected int Tuoi;
        protected bool GioiTinh;
        protected string DiaChi;
        public Nguoi()
        {
            this.CMND = "";
            this.Ten = "";
            this.Tuoi = 0;
            this.GioiTinh = ;
            this.DiaChi = "";
        }
        public Nguoi(string CMND, string Ten, int Tuoi, bool GioiTinh, string DiaChi)
        {
            this.CMND = CMND;
            this.Ten = Ten;
            this.Tuoi = Tuoi;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
        }
        public void NhapThongTin()
        {
            Console.WriteLine("CMND la: ");
            CMND = Console.ReadLine();
            Console.WriteLine("Ten la: ");
            Ten = Console.ReadLine();
            Console.WriteLine("Tuoi la: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("GioiTinh la: (True = Nu ; False = Nam)");
            GioiTinh = bool.Parse(Console.ReadLine());
            Console.WriteLine("DiaChi la: ");
            DiaChi = Console.ReadLine();
        }
        public void XuatThongTin()
        {
            Console.WriteLine("CMND la: " + CMND);
            Console.WriteLine("Ten la: " + Ten);
            Console.WriteLine("Tuoi la: " + Tuoi);
            Console.WriteLine("GioiTinh la: " + GioiTinh);
            Console.WriteLine("DiaChi la: " + DiaChi);
        }
    }
}

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
        public string getCMND(){return CMND;}
        public void setCMND(string cmnd){CMND = cmnd;}
        protected string Ten;
        public string getTen(){return Ten;}
        public void setTen(string ten){Ten = ten;}
        protected int Tuoi;
        public int getTuoi(){return Tuoi;}
        public void setTuoi(int tuoi){Tuoi = tuoi;}
        protected bool GioiTinh;
        public bool getGioiTinh(){return GioiTinh;}
        public void setGioiTinh(bool gioiTinh){GioiTinh = gioiTinh;}
        protected string DiaChi;
        public string getDiaChi(){return DiaChi;}
        public void setDiaChi(string diaChi){DiaChi = diaChi;}
        public Nguoi()
        {
            this.CMND = "";
            this.Ten = "";
            this.Tuoi = 1;
            this.GioiTinh = true;
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
            Console.Write("GioiTinh la: ");
            if (GioiTinh)
            {
                Console.WriteLine("Nữ");
            }
            else
            {
                Console.WriteLine("Nam");
            }
            Console.WriteLine("DiaChi la: " + DiaChi);
        }
    }
}

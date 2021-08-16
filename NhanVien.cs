using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class NhanVien:Nguoi
    {   
        string BangCap;
        public string getBangCap(){return this.BangCap;}
        public void setBangCap(string s){this.BangCap=s;}
        string ChucVu;
        public string getChucVu(){return this.ChucVu;}
        public void setChucVu(string s){this.ChucVu=s;}
        public NhanVien() : base()
        {
            this.BangCap = "";
            this.ChucVu = "";
        }
        public NhanVien(string CMND, string Ten, int Tuoi, bool GioiTinh, string DiaChi,
            string BangCap, string ChucVu)
            : base (CMND, Ten, Tuoi, GioiTinh, DiaChi)
        {
            this.BangCap = BangCap;
            this.ChucVu = ChucVu;
        }
        public void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("BangCap la: ");
            BangCap = Console.ReadLine();
            Console.WriteLine("ChucVu la: ");
            ChucVu = Console.ReadLine();
        }
        public void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("BangCap la: " + this.getBangCap());
            Console.WriteLine("ChucVu la: " + this.getChucVu());
        }
        void CapNhatBangCap()
        {

        }
        void ThayDoiChucVu()
        {

        }
    }
}

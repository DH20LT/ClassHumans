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
        string ChucVu;
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
        void CapNhatBangCap()
        {

        }
        void ThayDoiChucVu()
        {

        }
    }
}

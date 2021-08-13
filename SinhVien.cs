using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class SinhVien:Nguoi
    {
        string Lop;
        string NganhHoc;
        float DiemTB;
        public SinhVien() : base()
        {
            this.Lop = "";
            this.NganhHoc = "";
            this.DiemTB = 0;
        }
        public SinhVien
            (string CMND, string Ten, int Tuoi, bool GioiTinh, string DiaChi,
            string Lop, string NganhHoc, float DiemTB)
            : base(CMND, Ten, Tuoi, GioiTinh, DiaChi)
        {
            this.Lop = Lop;
            this.NganhHoc = NganhHoc;
            this.DiemTB = DiemTB;
        }
        public void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("CMND la: ");
            Lop = Console.ReadLine();
            Console.WriteLine("CMND la: ");
            NganhHoc = Console.ReadLine();
            Console.WriteLine("CMND la: ");
            DiemTB = float.Parse(Console.ReadLine());
        }
        public void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("Lop la: " + Lop);
            Console.WriteLine("NganhHoc la: " + NganhHoc);
            Console.WriteLine("DiemTB la: " + DiemTB);
        }

        public void TangDiemTB()
        {

        }
    }
}

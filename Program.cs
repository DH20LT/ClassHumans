using System;
using System.Collections.Generic;
using System.Collections;


namespace Humans
{
    class Program
    {
        static void Programming(ArrayList arrHuman){
            int iChucNang = int.Parse(Console.ReadLine());
            do{
                Console.WriteLine("Quản Lý Con Người");
                Console.WriteLine("1. Thêm đối tượng Nguoi");
                Console.WriteLine("2. Thêm đối tượng NhanVien");
                Console.WriteLine("3. Thêm đối tượng SinhVien");
                Console.WriteLine("0. Thoát Chương Trình");
                switch (iChucNang){
                    case 0:{ // Thoát Chương Trình
                        Environment.Exit(0);
                        break;
                    }
                    case 1:{ //Thêm đối tượng Nguoi
                        Nguoi nguoi = new Nguoi();
                        nguoi.NhapThongTin();
                        arrHuman.Add(nguoi);
                        break;
                    }
                    case 2: {
                        //Thêm đối tượng NhanVien
                        NhanVien nhanVien = new NhanVien();
                        nhanVien.NhapThongTin();
                        arrHuman.Add(nhanVien);
                        break;
                    }
                    case 3: { 
                        // Thêm đối tượng SinhVien
                        SinhVien sinhVien = new SinhVien();
                        sinhVien.NhapThongTin();
                        arrHuman.Add(sinhVien);
                        break;
                    }
                    case 4:{
                        //Hiện thị danh sách đối tượng
                        Console.WriteLine("Danh sách đối tượng");
                        foreach (var item in arrHuman)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;
                    }
                }
            }while(iChucNang > 0);

        }
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ArrayList arrHuman = new ArrayList();
            Programming(arrHuman);
        }
    }
}

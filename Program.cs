using System;
using System.Collections.Generic;
using System.Collections;


namespace Humans
{
    class Program
    {
        static void Programming(ArrayList arrHuman){
            Console.Clear();
            Console.WriteLine("Quản Lý Con Người");
            Console.WriteLine("1. Thêm đối tượng Nguoi");
            Console.WriteLine("2. Thêm đối tượng NhanVien");
            Console.WriteLine("3. Thêm đối tượng SinhVien");
            Console.WriteLine("4. Hiện tất cả đối tượng");
            Console.WriteLine("0. Thoát Chương Trình");
            Console.WriteLine("Chọn Chức năng");
            int iChucNang = int.Parse(Console.ReadLine());
            do{
                switch (iChucNang){
                    case 0:{ // Thoát Chương Trình
                        Environment.Exit(0);
                        break;
                    }
                    case 1:{ //Thêm đối tượng Nguoi
                        Nguoi nguoi = new Nguoi();
                        nguoi.NhapThongTin();
                        arrHuman.Add(nguoi);
                        Program.Programming(arrHuman);
                        break;
                    }
                    case 2: {
                        //Thêm đối tượng NhanVien
                        NhanVien nhanVien = new NhanVien();
                        nhanVien.NhapThongTin();
                        arrHuman.Add(nhanVien);
                        Program.Programming(arrHuman);
                        break;
                    }
                    case 3: { 
                        // Thêm đối tượng SinhVien
                        SinhVien sinhVien = new SinhVien();
                        sinhVien.NhapThongTin();
                        arrHuman.Add(sinhVien);
                        Program.Programming(arrHuman);
                        break;
                    }
                    case 4:{
                        //Hiện thị danh sách đối tượng
                        Console.WriteLine("Danh sách đối tượng");
                        for(int i = 0; i < arrHuman.Count; i++){
                            Nguoi nguoi = new Nguoi();
                            NhanVien nhanVien = new NhanVien();
                            SinhVien sinhVien = new SinhVien();

                            Type ia = arrHuman[i].GetType();
                            Type iNguoi = nguoi.GetType();
                            Type iNhanVien = nhanVien.GetType();
                            Type iSinhVien = sinhVien.GetType();
                            if (ia.Equals(iNguoi))
                            {
                                nguoi = (Nguoi)arrHuman[i];
                                Console.WriteLine("=====================================");
                                nguoi.XuatThongTin();
                                Console.WriteLine("=====================================");
                            }
                            else if(ia.Equals(iNhanVien))
                            {
                                nhanVien = (NhanVien)arrHuman[i];
                                Console.WriteLine("=====================================");
                                nhanVien.XuatThongTin();
                                Console.WriteLine("=====================================");
                            }
                            else if(ia.Equals(iSinhVien))
                            {
                                sinhVien = (SinhVien)arrHuman[i];
                                Console.WriteLine("=====================================");
                                sinhVien.XuatThongTin();
                                Console.WriteLine("=====================================");
                            }
                        }
                        Program.Programming(arrHuman);
                        break;
                    }
                }
            }while(true);

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

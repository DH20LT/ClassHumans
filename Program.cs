using System;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("Hello World!");
            Nguoi ng1 = new Nguoi();
            ng1.NhapThongTin();
            ng1.XuatThongTin();
        }
    }
}

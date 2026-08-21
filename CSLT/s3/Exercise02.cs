using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.s3
{

    internal class Exercise02
    {
        static void Bai1()
        {
            Console.WriteLine("Nhập chỉ số điện cũ (kWh): ");
            float csd_cu = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chỉ số điện mới (kwh): ");
            float csd_moi = float.Parse(Console.ReadLine());

            do
            {
                Console.Write("Nhập chỉ số điện mới (kwh): ");
                csd_moi = float.Parse(Console.ReadLine());
                if (csd_moi >= csd_cu)
                    break;
                else
                    Console.WriteLine("\t*** Chí số mới phải lớn hơn hoặc bằng chỉ số cũ");
            } while (true);
            float tieuThu = csd_moi - csd_cu;
            float dongia = 3059f;
            decimal tienDien = (decimal)(tieuThu * dongia);
            decimal vat = (decimal)(tieuThu * 0.08f);
            Console.WriteLine($"Số điện tiêu thụ: {tieuThu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDien}");
            Console.WriteLine($"Tiền thuế VAT: {vat}");
            Console.WriteLine($"Tổng thanh toán: {tienDien + vat}");

            Console.Write("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
        static void Bai2()
        {
            
        }
        static void Bai3() 
        {

        }
        static void Bai4() 
        {

        }
        static void Bai5() 
        {

        }
        static void Bai6() 
        {

        }
        static void Bai7() 
        {
        }
        static void Bai8() 
        {
        }
        static void Bai9() 
        {

        }
        static void Bai10()  
        {
        }
        static void Bai11() 
        {
        }
        static void Bai12() 
        {
        }
        static void Bai13() 
        {
        }
        static void Bai14()     
        {
        }
        static void Bai15() 
        {
        }

        static void Main(string[] args)
        {
            Bai1();
        }
    }
}

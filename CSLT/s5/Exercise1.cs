using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.s5
{
    public class Exercise1
    {
        static void CuuChuong()
        {
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine($"--- Bảng cửu chương {i} ---");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CuuChuong();
        }
    }
}

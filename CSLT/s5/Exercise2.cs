using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.s5
{
    public class Exercise2
    {
        static void Bai_1() // Bài 1: Kiểm tra loại tam giác
        {
            Console.Write("Nhập cạnh a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh c: ");
            int c = int.Parse(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("Tam giác đều");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Tam giác cân");
            else
                Console.WriteLine("Tam giác thường");
        }

        static void Bai_2() // Bài 2: Nhập 10 số, tính tổng và trung bình
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Nhập số thứ {i}: ");
                int x = int.Parse(Console.ReadLine());
                sum += x;
            }
            Console.WriteLine($"Tổng = {sum}, Trung bình = {(double)sum / 10}");
        }

        static void Bai_3() // Bài 3: In bảng cửu chương của một số
        {
            Console.Write("Nhập số nguyên: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
        static void Bai_4_5() // Bài 4 + 5: In các pattern số (tam giác và số liên tục)
        {
            // Pattern 1: tam giác số tăng dần theo cột
            Console.WriteLine("Pattern 1:");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }

            // Pattern 2: tam giác số liên tục từ 1 trở đi
            Console.WriteLine("\nPattern 2:");
            int num = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }

            // Pattern 3: tam giác số liên tục (giống pattern 2 nhưng có thể mở rộng)
            Console.WriteLine("\nPattern 3:");
            num = 1;
            for (int i = 1; i <= 4; i++)
            {
                
                for (int space = 4 - i; space > 0; space--)
                    Console.Write(" ");
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }

        static void Bai_6() // Bài 6: Dãy hàm điều hòa
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
                Console.Write($"1/{i} ");
            }
            Console.WriteLine($"\nTổng = {sum}");
        }

        static void Bai_7() // Bài 7: Tìm số hoàn hảo trong khoảng
        {
            Console.Write("Nhập giới hạn: ");
            int limit = int.Parse(Console.ReadLine());
            for (int n = 2; n <= limit; n++)
            {
                int sum = 0;
                for (int i = 1; i < n; i++)
                    if (n % i == 0) sum += i;
                if (sum == n)
                    Console.WriteLine($"{n} là số hoàn hảo");
            }
        }

        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        static void Bai_8() // Bài 8: Kiểm tra số nguyên tố
        {
            Console.Write("Nhập số nguyên: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(LaSoNguyenTo(x) ? $"{x} là số nguyên tố." : $"{x} không phải số nguyên tố.");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();
            Bai_3();
            Bai_4_5();
            Bai_6();
            Bai_7();
            Bai_8();
        }
    }
}

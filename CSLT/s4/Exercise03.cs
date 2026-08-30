using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.s4
{
    public class Exercise03
    {
        // Bài 1: Giải và biện luận phương trình bậc hai ax^2 + bx + c = 0
        static void Bai1()
        {
            Console.WriteLine("\n--- BÀI 1: GIẢI VÀ BIỆN LUẬN PHƯƠNG TRÌNH BẬC 2 (ax^2 + bx + c = 0) ---");

            Console.Write("Nhập hệ số a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập hệ số b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập hệ số c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("\n[CHI TIẾT BIỆN LUẬN]:");

            // TH1: Hệ số a = 0 -> Phương trình trở thành phương trình bậc nhất bx + c = 0
            if (a == 0)
            {
                Console.WriteLine("--> Hệ số a = 0: Phương trình trở thành phương trình bậc nhất bx + c = 0.");

                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("    + Vì b = 0 và c = 0 (0x + 0 = 0) => Phương trình có vô số nghiệm.");
                    }
                    else
                    {
                        Console.WriteLine($"    + Vì b = 0 và c = {c} != 0 (0x + {c} = 0) => Phương trình vô nghiệm.");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"    + Vì b = {b} != 0 => Phương trình có 1 nghiệm duy nhất: x = -c / b = {x}");
                }
            }
            // TH2: Hệ số a != 0 -> Phương trình bậc hai đầy đủ ax^2 + bx + c = 0
            else
            {
                Console.WriteLine($"--> Hệ số a = {a} != 0: Đây là phương trình bậc hai.");

                // Tính Delta: Δ = b^2 - 4ac
                double delta = b * b - 4 * a * c;
                Console.WriteLine($"--> Tính Delta (Δ = b^2 - 4ac) = ({b})^2 - 4*({a})*({c}) = {delta}");

                if (delta < 0)
                {
                    Console.WriteLine("    + Vì Delta < 0 => Phương trình vô nghiệm (không có nghiệm thực).");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"    + Vì Delta = 0 => Phương trình có nghiệm kép: x1 = x2 = -b / (2a) = {x}");
                }
                else // delta > 0
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("    + Vì Delta > 0 => Phương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine($"      x1 = (-b + √Δ) / (2a) = {x1}");
                    Console.WriteLine($"      x2 = (-b - √Δ) / (2a) = {x2}");
                }
            }
        }
        //2_1. Write a C# Sharp program to check whether a given number is even or odd.
        static void Bai2_1()
        {
            Console.WriteLine("\n--- BÀI 2.1: KIỂM TRA SỐ CHẴN HAY LẺ ---");
            Console.WriteLine("Nhập một số nguyên: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"Số {number} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"Số {number} là số lẻ.");
            }
        }
        //2_2. Write a C# Sharp program to find the largest of three numbers.
        static void Bai2_2()
        {
            Console.WriteLine("\n--- BÀI 2.2: TÌM SỐ LỚN NHẤT TRONG 3 SỐ ---");

            Console.Write("Nhập số đầu tiên : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ 3: ");
            int c = int.Parse(Console.ReadLine());

            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }

            Console.WriteLine($"Số thứ nhất là: {a}\nSố thứ hai là: {b}\nSố thứ ba là: {c}");
            Console.WriteLine($"Số lớn nhất trong ba số là: {max}");
        }
        //2_3. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        static void Bai2_3()
        {
            Console.WriteLine("\n--- BÀI 2.3: KIỂM TRA LOẠI TAM GIÁC ---");

            Console.Write("Nhập cạnh thứ nhất của tam giác: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh thứ hai của tam giác: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh thứ ba của tam giác: ");
            int side3 = int.Parse(Console.ReadLine());

            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("Tam giác đều.");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("Tam giác cân.");
                }
                else
                {
                    Console.WriteLine("Tam giác thường.");
                }
            }
            else
            {
                Console.WriteLine("Đây không phải là tam giác hợp lệ.");
            }
        }
        //2_4. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        static void Bai2_4()
        {
            Console.WriteLine("\n--- BÀI 2.4: XÁC ĐỊNH TỌA ĐỘ TRONG HỆ TRỤC TOẠ ĐỘ XY ---");
            Console.Write("Nhập hoành độ (x): ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập tung độ (y): ");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"Điểm ({x}, {y}) nằm ở góc phần tư thứ I.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"Điểm ({x}, {y}) nằm ở góc phần tư thứ II.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"Điểm ({x}, {y}) nằm ở góc phần tư thứ III.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"Điểm ({x}, {y}) nằm ở góc phần tư thứ IV.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine($"Điểm ({x}, {y}) nằm trên trục tung.");
            }
            else if (y == 0 && x != 0)
            {
                Console.WriteLine($"Điểm ({x}, {y}) nằm trên trục hoành.");
            }
            else
            {
                Console.WriteLine($"Điểm ({x}, {y}) là gốc tọa độ.");
            }
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Bai1();
            Bai2_1();
            Bai2_2();
            Bai2_3();
            Bai2_4();
        }
    }
}

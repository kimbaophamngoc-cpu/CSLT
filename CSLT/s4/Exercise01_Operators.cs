using System;


namespace CSLT.s4
{
    internal class Exercise01_Operators
    {
        static void Bai1()
        {
            // 1. Write a C# Sharp program that takes two numbers as input and performs an operation(+, -, *, x,/) on them and displays the result of that operation.
            Console.Write("Nhap so a = "); int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b = "); int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b }");
            Console.WriteLine($"{a} - {b} = {a - b }");
            Console.WriteLine($"{a} * {b} = {a * b }");
            Console.WriteLine($"{a} / {b} = {(float)a / b }");
            Console.WriteLine($"{a} % {b} = {a % b }");
        }
        static void Bai2()
        {
            // 2. Write a C# Sharp program to display certain values of the function x = y + 2y + 1(using integer numbers for y, ranging from - 5 to + 5).
            Console.WriteLine("y\t\tx = y^2 + 2y + 1");
            for (int y = -5; y <= 5; y++)
            {
                int x = y*y  + 2 * y + 1;
                Console.WriteLine($"{y}\t\t{x}");
            }

        }
        static void Bai3()
        {
            // 3. Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour(km / h) and miles per hour(miles/ h).             
            Console.WriteLine("Nhap khoan cach (km): ");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thoi gian (gio phut giay): ");
            Console.Write("Nhap gio: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Nhap phut: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Nhap giay: ");
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine($"Toc do: {distance / (hours + minutes / 60.0 + seconds / 3600.0)} km/h");
            Console.WriteLine($"Toc do: {distance / (hours + minutes / 60.0 + seconds / 3600.0) * 0.621371} miles/h");
        }
        static void Bai4()
        {
            // 4. Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere. V = 4 / 3 * π * r3
            Console.Write("Nhap ban kinh hinh cau: ");
            double radius = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * radius * radius;
            double volume = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Dien tich hinh cau: {surface}");
            Console.WriteLine($"Dien tich hinh cau: {surface} = 4 * {Math.PI} * {radius} * {radius}");
            Console.WriteLine($"The tich hinh cau: {volume}");
            Console.WriteLine($"The tich hinh cau: {volume} = {4.0 / 3} * {Math.PI} * {Math.Pow(radius, 3)}");
        }
        static void Bai5()
        {
            // 5. Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
            
            Console.WriteLine("Nhap vao mot ky tu ");
            char c = char.Parse(Console.ReadLine());
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine($"{c} la nguyen am.");
            }
            else if (c >= '0' && c <= '9')
            {
                Console.WriteLine($"{c} la chu so.");
            }
            else
            {
                Console.WriteLine($"{c} la ky tu khac.");
            }
        }
        static void phuongtrinhbachai(int a, int b, int c)
        {
            if (a == 0)
            {
                // Phương trình bậc nhất: bx + c = 0
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phương trình có vô số nghiệm.");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm.");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phương trình bậc nhất có nghiệm:");
                    Console.WriteLine("x = " + x);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phương trình có nghiệm kép:");
                    Console.WriteLine("x = " + x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }

            }
            
        }
        static void Main(string[] args)
        {

            Bai1();
            Bai2();
            Bai3();
            Bai4();
            Bai5();
            phuongtrinhbachai(1, 3, 2);
        }
    }
}

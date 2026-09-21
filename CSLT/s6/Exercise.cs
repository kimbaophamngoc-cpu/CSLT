using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.s6
{
    internal class Exercise
    {
        // 1. TÌM SỐ LỚN NHẤT
        static int FindMax(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        static int FindMaxAdvanced(int first, params int[] rest)
        {
            int max = first;
            foreach (int num in rest)
            {
                if (num > max) max = num;
            }
            return max;
        }

        // 2. TÍNH GIAI THỪA (FACTORIAL)
        static long Factorial(int n)
        {
            if (n < 0) return -1; 

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // 3. KIỂM TRA SỐ NGUYÊN TỐ
        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // 4. IN SỐ NGUYÊN TỐ
        // 4.1: In tất cả số nguyên tố nhỏ hơn N
        static void PrintPrimesLessThan(int limit)
        {
            Console.Write($"Các số nguyên tố nhỏ hơn {limit}: ");
            for (int i = 2; i < limit; i++)
            {
                if (IsPrime(i)) Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // 4.2: In N số nguyên tố đầu tiên
        static void PrintFirstNPrimes(int count)
        {
            Console.Write($"{count} số nguyên tố đầu tiên: ");
            int found = 0;
            int current = 2;
            while (found < count)
            {
                if (IsPrime(current))
                {
                    Console.Write(current + " ");
                    found++;
                }
                current++;
            }
            Console.WriteLine();
        }

        // 5. SỐ HOÀN HẢO (PERFECT NUMBER)
        static bool IsPerfect(int number)
        {
            if (number <= 1) return false;
            int sum = 1;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0) sum += i;
            }
            return sum == number;
        }

        static void PrintPerfectNumbersLessThan1000()
        {
            Console.Write("Các số hoàn hảo nhỏ hơn 1000: ");
            for (int i = 1; i < 1000; i++)
            {
                if (IsPerfect(i)) Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // 6. KIỂM TRA PANGRAM
        static bool IsPangram(string str)
        {
            str = str.ToLower();
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                if (!str.Contains(ch)) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //1. Tìm số lớn nhất
            Console.WriteLine("--- 1. TÌM SỐ LỚN NHẤT ---");
            Console.Write("Nhập số thứ nhất (a): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai (b): ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba (c): ");
            int c = int.Parse(Console.ReadLine());

            int max3 = FindMax(a, b, c);
            Console.WriteLine($"Max của ({a}, {b}, {c}) là: {max3}");

            Console.Write("\nNhập một danh sách các số cách nhau bởi dấu cách (để test FindMaxAdvanced): ");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (numbers.Length > 0)
            {
                int maxAdvanced = FindMaxAdvanced(numbers[0], numbers.Skip(1).ToArray());
                Console.WriteLine($"Max nâng cao là: {maxAdvanced}");
            }

            //2. Tính giai thừa
            Console.WriteLine("\n--- 2. TÍNH GIAI THỪA ---");
            Console.Write("Nhập số nguyên không âm n: ");
            int nFact = int.Parse(Console.ReadLine());
            long factorialResult = Factorial(nFact);
            if (factorialResult == -1)
            {
                Console.WriteLine("Số nhập vào không hợp lệ. Vui lòng nhập số nguyên không âm.");
            }
            else
            {
                Console.WriteLine($"{nFact}! = {factorialResult}");
            }

            //3. Kiểm tra số nguyên tố
            Console.WriteLine("\n--- 3. KIỂM TRA SỐ NGUYÊN TỐ ---");
            Console.Write("Nhập số cần kiểm tra nguyên tố: ");
            int numberCheck = int.Parse(Console.ReadLine());
            bool isPrime = IsPrime(numberCheck);
            Console.WriteLine($"Số {numberCheck} là số nguyên tố: {isPrime}");

            //4.1
            Console.WriteLine("\n--- 4. IN SỐ NGUYÊN TỐ ---");
            Console.Write("Nhập số N để tìm các số nguyên tố nhỏ hơn N: ");
            int limitN = int.Parse(Console.ReadLine());
            PrintPrimesLessThan(limitN);

            //4.2
            Console.Write("Nhập N (số lượng số nguyên tố đầu tiên cần in): ");
            int countN = int.Parse(Console.ReadLine());
            PrintFirstNPrimes(countN);

            //5. Số hoàn hảo
            Console.WriteLine("\n--- 5. SỐ HOÀN HẢO ---");
            Console.Write("Nhập số cần kiểm tra số hoàn hảo: ");
            int perfectCheck = int.Parse(Console.ReadLine());
            bool isPerfect = IsPerfect(perfectCheck);
            Console.WriteLine($"Số {perfectCheck} là số hoàn hảo: {isPerfect}");

            PrintPerfectNumbersLessThan1000();

            //6. Kiểm tra Pangram
            Console.WriteLine("\n--- 6. KIỂM TRA PANGRAM ---");
            Console.Write("Nhập chuỗi cần kiểm tra Pangram: ");
            string sampleText = Console.ReadLine();
            bool isPangram = IsPangram(sampleText);
            Console.WriteLine($"Chuỗi: \"{sampleText}\"");
            Console.WriteLine($"Là Pangram: {isPangram}");

            Console.ReadKey();
        }
    }
}
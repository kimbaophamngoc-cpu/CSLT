using System;
using System.Linq;
using System.Text;

namespace CSLT.s6
{
    public class Exercise05
    {
        // Bài 1
        static int TinhTong(int a, int b)
        {
            return a + b;
        }

        // Bài 2
        static bool KiemTraChan(int n)
        {
            if (n % 2 == 0) return true;
            else return false;
        }

        // Bài 3
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
            
        // Bài 4
        static long TinhGiaiThua(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++) result *= i;
            return result;
        }

        // Bài 5
        static string DaoNguocChuoi(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        // Bài 6
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        // Bài 7
        static void InFibonacci(int n)
        {
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }

        // Bài 8
        static int DemNguyenAm(string s)
        {
            string nguyenAm = "aàáảãạăằắẳẵặâầấẩẫậeèéẻẽẹêềếểễệiìíỉĩịoòóỏõọôồốổỗộơờớởỡợuùúủũụưừứửữựyỳýỷỹỵ" +
                             "AÀÁẢÃẠĂẰẮẲẴẶÂẦẤẨẪẬEÈÉẺẼẸÊỀẾỂỄỆIÌÍỈĨỊOÒÓỎÕỌÔỒỐỔỖỘƠỜỚỞỠỢUÙÚỦŨỤƯỪỨỬỮỰYỲÝỶỸỴ";

            int count = 0;

            foreach (char c in s)
            {
                for (int i = 0; i < nguyenAm.Length; i++)
                {
                    if (c == nguyenAm[i])
                    {
                        count++;
                        break; 
                    }
                }
            }

            return count;
        }

        // Bài 9
        static double TinhLuyThua(double x, int y)
        {
            double result = 1;
            for (int i = 0; i < y; i++) result *= x;
            return result;
        }

        // Bài 10
        static double TinhTrungBinh(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return (double)sum / arr.Length;
        }

        // Bài 11
        static bool KiemTraDoiXung(string s)
        {
            if (s == null || s.Length == 0)
            {
                return true;
            }

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false; 
                }
                left++;
                right--;
            }

            return true;
        }

        // Bài 12
        static double CelsiusToFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }

        // Bài 13
        static int TimMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i]; 
                }
            }

            return min;
        }

        // Bài 14
        static int TongCacChuSo(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        // Bài 15
        static void SapXepMang(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);

                if (i < arr.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        // Bài 16
        static string XoaTrungLap(string s)
        {
            string result = "";

            foreach (char c in s)
            {
                bool daTonTai = false;
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == c)
                    {
                        daTonTai = true;
                        break; 
                    }
                }

                if (!daTonTai)
                {
                    result += c;
                }
            }

            return result;
        }

        // Bài 17
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Bài 18
        static string DecimalToBinary(int n)
        {           
            if (n == 0) return "0";

            string binary = "";
            int temp = n;

            while (temp > 0)
            {
                int remainder = temp % 2; 
                binary = remainder + binary; 
                temp = temp / 2;             
            }

            return binary;
        }

        // Bài 19
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        // Bài 20
        static int DemSoTu(string sentence)
        {
            if (sentence == null) return 0;

            int count = 0;

            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                char c = sentence[i];
                bool isSpace = (c == ' ' || c == '\t' || c == '\n' || c == '\r');

                if (isSpace == false)
                {
                    if (i == sentence.Length - 1 ||
                        sentence[i + 1] == ' ' || sentence[i + 1] == '\t' ||
                        sentence[i + 1] == '\n' || sentence[i + 1] == '\r')
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Bài 1
            Console.WriteLine("Bài 1: Nhập a, b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Tổng = " + TinhTong(a, b));

            // Bài 2
            Console.WriteLine("Bài 2: Nhập n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Chẵn? " + KiemTraChan(n));

            // Bài 3
            Console.WriteLine("Bài 3: Nhập 3 số");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Max = " + TimMax(x, y, z));

            // Bài 4
            Console.WriteLine("Bài 4: Nhập n");
            int gt = int.Parse(Console.ReadLine());
            Console.WriteLine("Giai thừa = " + TinhGiaiThua(gt));

            // Bài 5
            Console.WriteLine("Bài 5: Nhập chuỗi");
            string s = Console.ReadLine();
            Console.WriteLine("Đảo ngược = " + DaoNguocChuoi(s));

            // Bài 6
            Console.WriteLine("Bài 6: Nhập n");
            int nt = int.Parse(Console.ReadLine());
            Console.WriteLine("Nguyên tố? " + KiemTraNguyenTo(nt));

            // Bài 7
            Console.WriteLine("Bài 7: Nhập số lượng Fibonacci");
            int fib = int.Parse(Console.ReadLine());
            InFibonacci(fib);

            // Bài 8
            Console.WriteLine("Bài 8: Nhập chuỗi");
            string s8 = Console.ReadLine();
            Console.WriteLine("Nguyên âm = " + DemNguyenAm(s8));

            // Bài 9
            Console.WriteLine("Bài 9: Nhập x, y");
            double x9 = double.Parse(Console.ReadLine());
            int y9 = int.Parse(Console.ReadLine());
            Console.WriteLine("x^y = " + TinhLuyThua(x9, y9));

            // Bài 10
            Console.WriteLine("Bài 10: Nhập mảng (cách nhau bởi dấu cách)");
            int[] arr10 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine("Trung bình = " + TinhTrungBinh(arr10));

            // Bài 11
            Console.WriteLine("Bài 11: Nhập chuỗi");
            string s11 = Console.ReadLine();
            Console.WriteLine("Đối xứng? " + KiemTraDoiXung(s11));

            // Bài 12
            Console.WriteLine("Bài 12: Nhập độ C");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Độ F = " + CelsiusToFahrenheit(c));

            // Bài 13
            Console.WriteLine("Bài 13: Nhập mảng");
            int[] arr13 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine("Min = " + TimMin(arr13));

            // Bài 14
            Console.WriteLine("Bài 14: Nhập số");
            int n14 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tổng chữ số = " + TongCacChuSo(n14));

            // Bài 15
            Console.WriteLine("Bài 15: Nhập mảng");
            int[] arr15 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            SapXepMang(arr15);

            // Bài 16
            Console.WriteLine("Bài 16: Nhập chuỗi");
            string s16 = Console.ReadLine();
            Console.WriteLine("Xóa trùng = " + XoaTrungLap(s16));

            // Bài 17
            Console.WriteLine("Bài 17: Nhập a, b");
            int a17 = int.Parse(Console.ReadLine());
            int b17 = int.Parse(Console.ReadLine());
            Console.WriteLine("UCLN = " + UCLN(a17, b17));

            // Bài 18
            Console.WriteLine("Bài 18: Nhập số thập phân");
            int n18 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhị phân = " + DecimalToBinary(n18));

            // Bài 19
            Console.WriteLine("Bài 19: Nhập năm");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Năm nhuận? " + KiemTraNamNhuan(year));

            // Bài 20
            Console.WriteLine("Bài 20: Nhập câu");
            string sentence = Console.ReadLine();
            Console.WriteLine("Số từ = " + DemSoTu(sentence));
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSLT.s9
{
    internal class Exercise08
    {
        // 1. Tạo tệp rỗng trên đĩa
        public static void CreateBlankFile(string filePath)
        {
            File.Create(filePath).Close();
        }

        // 2. Xóa tệp khỏi đĩa
        public static bool RemoveFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                return true;
            }
            return false;
        }

        // 3. Tạo tệp và ghi văn bản
        public static void CreateAndAddText(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }

        // 4. Tạo tệp văn bản và đọc nội dung
        public static string ReadTextFile(string filePath)
        {
            if (!File.Exists(filePath)) return "File không tồn tại!";

            using (StreamReader sr = new StreamReader(filePath))
            {
                return sr.ReadToEnd();
            }
        }

        // 5. Tạo tệp và ghi một mảng chuỗi
        public static void WriteStringArray(string filePath, string[] lines)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (string s in lines)
                {
                    sw.WriteLine(s);
                }
            }
        }

        // 6. Nối (append) văn bản vào tệp hiện có
        public static void AppendTextToFile(string filePath, string text)
        {
            File.AppendAllText(filePath, text);
        }

        // 7. Tạo, sao chép tệp sang tên khác và hiển thị nội dung
        public static string CopyAndRead(string sourcePath, string destPath)
        {
            File.Copy(sourcePath, destPath, overwrite: true);
            return ReadTextFile(destPath);
        }

        // 8. Tạo tệp và di chuyển sang tên khác trong cùng thư mục
        public static void MoveFile(string sourcePath, string destPath)
        {
            if (File.Exists(destPath)) File.Delete(destPath);
            File.Move(sourcePath, destPath);
        }

        // 9. Đọc dòng đầu tiên của tệp
        public static string ReadFirstLine(string filePath)
        {
            if (!File.Exists(filePath)) return null;
            using (StreamReader sr = new StreamReader(filePath))
            {
                return sr.ReadLine(); 
            }
        }

        // 10. Tạo và đọc dòng cuối cùng của tệp
        public static string ReadLastLine(string filePath)
        {
            if (!File.Exists(filePath)) return null;
            string[] lines = File.ReadAllLines(filePath);
            return lines.Length > 0 ? lines[lines.Length - 1] : "";
        }

        // 11. Tạo và đọc N dòng cuối cùng của tệp
        public static string[] ReadLastNLines(string filePath, int n)
        {
            if (!File.Exists(filePath)) return new string[0];
            string[] lines = File.ReadAllLines(filePath);
            return lines.Skip(Math.Max(0, lines.Length - n)).ToArray();
        }

        // 12. Đọc một dòng cụ thể (dòng thứ n, bắt đầu từ 1)
        public static string ReadSpecificLine(string filePath, int lineNumber)
        {
            if (!File.Exists(filePath)) return null;
            string[] lines = File.ReadAllLines(filePath);
            if (lineNumber >= 1 && lineNumber <= lines.Length)
            {
                return lines[lineNumber - 1];
            }
            return null;
        }

        // 13. Đếm tổng số dòng trong tệp
        public static int CountLines(string filePath)
        {
            if (!File.Exists(filePath)) return 0;
            return File.ReadAllLines(filePath).Length;
        }

        // 14. In cấu trúc thư mục cụ thể (bao gồm các tệp)
        public static void PrintFolderStructure(string dirPath, string indent = "")
        {
            if (!Directory.Exists(dirPath)) return;

            DirectoryInfo dir = new DirectoryInfo(dirPath);
            Console.WriteLine($"{indent}[{dir.Name}]");

            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine($"{indent}  ├── {file.Name}");
            }

            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                PrintFolderStructure(subDir.FullName, indent + "  ");
            }
        }

        // 15a. Thống kê số lần xuất hiện của ký tự & số bằng Mảng Chữ Nhật 2D (Rectangular Array)
        public static int[,] CalculateCharFrequency2D(string filePath)
        {
            int[,] stats = new int[256, 2];
            for (int i = 0; i < 256; i++) stats[i, 0] = i;

            if (!File.Exists(filePath)) return stats;

            string content = File.ReadAllText(filePath);
            foreach (char c in content)
            {
                if (c < 256) stats[c, 1]++;
            }
            return stats;
        }

        // 15b. Thống kê vị trí xuất hiện (Dòng, Cột) bằng Mảng Răng Cưa (Jagged Array)
        public static (int Line, int Col)[][] FindCharPositionsJagged(string filePath)
        {
            List<(int, int)>[] listPositions = new List<(int, int)>[256];
            for (int i = 0; i < 256; i++) listPositions[i] = new List<(int, int)>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int l = 0; l < lines.Length; l++)
                {
                    for (int c = 0; c < lines[l].Length; c++)
                    {
                        char ch = lines[l][c];
                        if (ch < 256)
                        {
                            listPositions[ch].Add((l + 1, c + 1)); 
                        }
                    }
                }
            }

            (int Line, int Col)[][] jaggedArray = new (int Line, int Col)[256][];
            for (int i = 0; i < 256; i++)
            {
                jaggedArray[i] = listPositions[i].ToArray();
            }
            return jaggedArray;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string baseDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DemoFolder");
            Directory.CreateDirectory(baseDir);

            string file1 = Path.Combine(baseDir, "file1.txt");
            string file2 = Path.Combine(baseDir, "file2.txt");
            string copyFile = Path.Combine(baseDir, "file1_copy.txt");
            string movedFile = Path.Combine(baseDir, "file1_renamed.txt");

            Console.WriteLine("=================== KẾT QUẢ THỰC THI THAO TÁC FILE ===================\n");

            // 1. Tạo tệp rỗng
            CreateBlankFile(file1);
            Console.WriteLine("1. Đã tạo tệp rỗng: file1.txt");

            // 2. Xóa tệp
            CreateBlankFile(file2);
            bool isDeleted = RemoveFile(file2);
            Console.WriteLine($"2. Xóa tệp file2.txt: {(isDeleted ? "Thành công" : "Thất bại")}");

            // 3. Tạo tệp và ghi văn bản
            CreateAndAddText(file1, "Line 1: Hello C# File System.\n");
            Console.WriteLine("3. Đã ghi văn bản vào file1.txt");

            // 4. Đọc tệp
            Console.WriteLine("\n4. Nội dung file1.txt đọc được:");
            Console.WriteLine(ReadTextFile(file1));

            // 5. Ghi mảng chuỗi
            string[] items = { "Line 2: Visual Studio 2022", "Line 3: NET Core Architecture", "Line 4: System IO Operations", "Line 5: End of array data" };
            WriteStringArray(file1, items);
            Console.WriteLine("5. Đã ghi mảng chuỗi vào file1.txt");

            // 6. Append nối văn bản
            AppendTextToFile(file1, "Line 6: Appended line text.\n");
            Console.WriteLine("6. Đã nối nội dung mới vào file1.txt");

            // 7. Copy và hiển thị nội dung
            string copyContent = CopyAndRead(file1, copyFile);
            Console.WriteLine("\n7. Nội dung tệp sao chép (file1_copy.txt):\n" + copyContent);

            // 8. Di chuyển/Đổi tên tệp
            MoveFile(copyFile, movedFile);
            Console.WriteLine("8. Đã đổi tên file1_copy.txt -> file1_renamed.txt");

            // 9. Đọc dòng đầu tiên
            Console.WriteLine("\n9. Dòng đầu tiên: " + ReadFirstLine(file1));

            // 10. Đọc dòng cuối cùng
            Console.WriteLine("10. Dòng cuối cùng: " + ReadLastLine(file1));

            // 11. Đọc 3 dòng cuối cùng
            Console.WriteLine("\n11. 3 dòng cuối cùng của tệp:");
            foreach (var line in ReadLastNLines(file1, 3))
            {
                Console.WriteLine("   " + line);
            }

            // 12. Đọc dòng cụ thể (Ví dụ: dòng 2)
            Console.WriteLine("\n12. Dòng thứ 2: " + ReadSpecificLine(file1, 2));

            // 13. Đếm số dòng
            Console.WriteLine("13. Tổng số dòng trong file1.txt: " + CountLines(file1));

            // 14. In cấu trúc thư mục
            Console.WriteLine("\n14. Cấu trúc thư mục DemoFolder:");
            PrintFolderStructure(baseDir);

            // 15. Thống kê ký tự / số bằng Mảng 2D và Jagged Array
            Console.WriteLine("\n15. THỐNG KÊ KÝ TỰ & SỐ TỪ FILE:");

            // a. Sử dụng Mảng chữ nhật 2D
            int[,] stats2D = CalculateCharFrequency2D(file1);
            Console.WriteLine("--- Tần suất xuất hiện (Mảng chữ nhật 2D) ---");
            for (int i = 0; i < 256; i++)
            {
                if (stats2D[i, 1] > 0 && !char.IsControl((char)i))
                {
                    Console.WriteLine($"  Ký tự '{(char)stats2D[i, 0]}' xuất hiện: {stats2D[i, 1]} lần");
                }
            }

            // b. Sử dụng Jagged Array lấy vị trí (Dòng, Cột)
            var jaggedPos = FindCharPositionsJagged(file1);
            Console.WriteLine("\n--- Vị trí xuất hiện [Dòng, Cột] (Mảng răng cưa - Jagged Array) ---");
            for (int i = 0; i < 256; i++)
            {
                if (jaggedPos[i].Length > 0 && char.IsLetterOrDigit((char)i))
                {
                    Console.Write($"  Ký tự '{(char)i}': ");
                    foreach (var pos in jaggedPos[i])
                    {
                        Console.Write($"[{pos.Line},{pos.Col}] ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
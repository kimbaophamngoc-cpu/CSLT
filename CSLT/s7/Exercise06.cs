using System;
using System.Text;

namespace CSLT.s7
{
    public class Exercise06
    {
        //▸Create a random integer values array, then create functions that:
        static void nhap_mang_ngau_nhien(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(10, 500); 
            }
        }

        static void in_mang(int[] a)
        {
            foreach (int v in a)
                Console.Write($"{v} ");
            Console.WriteLine();
        }

        //1.to calculate the average value of array elements.
        static float calcAvg(int[] a)
        {
            int sum = 0;
            foreach (int v in a)
                sum += v;
            return (float)sum / a.Length;
        }

        //2.to test if an array contains a specific value.
        static bool contains(int[] a, int value)
        {
            foreach (int v in a)
                if (v == value)
                    return true;
            return false;
        }

        //3.to find the index of an array element.
        static int findIndex(int[] a, int value)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == value)
                    return i;
            return -1;
        }

        //4.to remove a specific element from an array.
        static int[] removeElement(int[] a, int value)
        {
            int index = findIndex(a, value);
            if (index == -1) return a; 

            int[] result = new int[a.Length - 1];
            int pos = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i == index) continue;
                result[pos++] = a[i];
            }
            return result;
        }

        //5.to find the maximum and minimum value of an array.
        static (int max, int min) findMaxMin(int[] a)
        {
            int max = a[0];
            int min = a[0];
            foreach (int v in a)
            {
                if (v > max) max = v;
                if (v < min) min = v;
            }
            return (max, min);
        }

        //6.to reverse an array of integer values.
        static int[] reverseArray(int[] a)
        {
            int[] reversed = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                reversed[i] = a[a.Length - 1 - i];
            return reversed;
        }

        //7.to find duplicate values in an array of values.
        static int[] findDuplicates(int[] a)
        {
            int[] temp = new int[a.Length];
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (isDuplicate && !contains(temp, a[i]))
                {
                    temp[count++] = a[i];
                }
            }

            int[] duplicates = new int[count];
            for (int i = 0; i < count; i++)
            {
                duplicates[i] = temp[i];
            }
            return duplicates;
        }

        //8.to remove duplicate elements from an array.
        static int[] removeDuplicates(int[] a)
        {
            int[] temp = new int[a.Length];
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                bool exists = false;
                for (int j = 0; j < count; j++)
                {
                    if (temp[j] == a[i])
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    temp[count++] = a[i];
                }
            }

            int[] unique = new int[count];
            for (int i = 0; i < count; i++)
            {
                unique[i] = temp[i];
            }
            return unique;
        }


        //▸Create a C# program that
        //-requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
        static void bubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        //-Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm.
        static bool compareCharIgnoreCase(char c1, char c2)
        {
            if (c1 >= 'A' && c1 <= 'Z') c1 = (char)(c1 + 32);
            if (c2 >= 'A' && c2 <= 'Z') c2 = (char)(c2 + 32);
            return c1 == c2;
        }

        static bool linearSearch(string sentence, string word)
        {
            int sLen = sentence.Length;
            int wLen = word.Length;

            if (wLen == 0 || sLen < wLen) return false;

            for (int i = 0; i <= sLen - wLen; i++)
            {
                bool match = true;
                for (int j = 0; j < wLen; j++)
                {
                    if (!compareCharIgnoreCase(sentence[i + j], word[j]))
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    bool leftValid = (i == 0) || sentence[i - 1] == ' ' || sentence[i - 1] == ',' || sentence[i - 1] == '.';
                    bool rightValid = (i + wLen == sLen) || sentence[i + wLen] == ' ' || sentence[i + wLen] == ',' || sentence[i + wLen] == '.';

                    if (leftValid && rightValid)
                        return true;
                }
            }
            return false;
        }

        //▸Create a program with following functions
        //-Create an integer matrix N x M(N, M was prompted from user) randomly.
        static int[,] createRandomMatrix(int n, int m)
        {
            Random rnd = new Random();
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = rnd.Next(10, 100);
            return matrix;
        }

        //-Print the matrix.
        static void printMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //-Print the ith row/column. (i was prompted from user)
        static void printRow(int[,] matrix, int rowIndex)
        {
            int m = matrix.GetLength(1);
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[rowIndex, j] + "\t");
            }
            Console.WriteLine();
        }

        static void printColumn(int[,] matrix, int colIndex)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(matrix[i, colIndex]);
            }
        }

        //-Find the max value of the matrix.
        static int findMaxValue(int[,] matrix)
        {
            int max = matrix[0, 0];
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
            return max;
        }

        //-Find the min value of ith row/col of the matrix.
        static int findMinInRow(int[,] matrix, int rowIndex)
        {
            int min = matrix[rowIndex, 0];
            int m = matrix.GetLength(1);
            for (int j = 1; j < m; j++)
            {
                if (matrix[rowIndex, j] < min)
                    min = matrix[rowIndex, j];
            }
            return min;
        }

        static int findMinInCol(int[,] matrix, int colIndex)
        {
            int min = matrix[0, colIndex];
            int n = matrix.GetLength(0);
            for (int i = 1; i < n; i++)
            {
                if (matrix[i, colIndex] < min)
                    min = matrix[i, colIndex];
            }
            return min;
        }

        //-Transpose the matrix.
        static int[,] transposeMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int[,] transposed = new int[m, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    transposed[j, i] = matrix[i, j];
            return transposed;
        }

        //-Print the main/secondary diagonal values of the matrix.(square maxtrix)
        static void printMainDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, i] + "\t");
            }
            Console.WriteLine();
        }

        static void printSecondaryDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, n - 1 - i] + "\t");
            }
            Console.WriteLine();
        }

        // ===================================================================
        // CHƯƠNG TRÌNH CHÍNH (ĐÃ THÊM NHẬP DỮ LIỆU TỪ BÀN PHÍM)
        // ===================================================================

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // ---------------------------------------------------------------
            // PHẦN 1: MẢNG 1 CHIỀU
            // ---------------------------------------------------------------
            Console.WriteLine("=================== PHẦN 1: MẢNG 1 CHIỀU ===================");
            int[] array = new int[10];
            nhap_mang_ngau_nhien(array);
            Console.Write("Mảng ngẫu nhiên ban đầu: ");
            in_mang(array);

            Console.WriteLine($"1. Giá trị trung bình: {calcAvg(array)}");

            Console.Write("2. Nhập một số để kiểm tra xem mảng có chứa không: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine($"   Mảng có chứa {target} không?: {contains(array, target)}");

            Console.WriteLine($"3. Vị trí (index) của {target}: {findIndex(array, target)}");

            Console.Write("4. Nhập một giá trị cần xóa khỏi mảng: ");
            int valueToRemove = int.Parse(Console.ReadLine());
            int[] removedArray = removeElement(array, valueToRemove);
            Console.Write("   Mảng sau khi xóa: ");
            in_mang(removedArray);

            var (max, min) = findMaxMin(array);
            Console.WriteLine($"5. Giá trị lớn nhất (Max): {max}, Nhỏ nhất (Min): {min}");

            int[] reversedArray = reverseArray(array);
            Console.Write("6. Mảng sau khi đảo ngược: ");
            in_mang(reversedArray);

            int[] duplicates = findDuplicates(array);
            Console.Write("7. Các phần tử bị trùng lặp: ");
            in_mang(duplicates);

            int[] uniqueArray = removeDuplicates(array);
            Console.Write("8. Mảng sau khi xóa các phần tử trùng lặp: ");
            in_mang(uniqueArray);


            // ---------------------------------------------------------------
            // PHẦN 2: BUBBLE SORT & TÌM KIẾM TUYẾN TÍNH
            // ---------------------------------------------------------------
            Console.WriteLine("\n=================== PHẦN 2: BUBBLE SORT & LINEAR SEARCH ===================");

            int[] userArray = new int[10];
            Console.WriteLine("Nhập vào 10 số nguyên:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Phần tử thứ [{i}]: ");
                userArray[i] = int.Parse(Console.ReadLine());
            }

            bubbleSort(userArray);
            Console.Write("Mảng sau khi sắp xếp (Bubble Sort): ");
            in_mang(userArray);

            Console.WriteLine("\n--- Tìm kiếm từ trong câu ---");
            Console.Write("Nhập vào một câu: ");
            string sentence = Console.ReadLine();

            Console.Write("Nhập vào từ cần tìm: ");
            string wordToSearch = Console.ReadLine();

            bool found = linearSearch(sentence, wordToSearch);
            Console.WriteLine($"Từ '{wordToSearch}' có xuất hiện trong câu không?: {found}");


            // ---------------------------------------------------------------
            // PHẦN 3: MA TRẬN 2 CHIỀU
            // ---------------------------------------------------------------
            Console.WriteLine("\n=================== PHẦN 3: MA TRẬN 2 CHIỀU ===================");

            Console.Write("Nhập số hàng N: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột M: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = createRandomMatrix(rows, cols);
            Console.WriteLine($"\nMa trận ngẫu nhiên ({rows}x{cols}):");
            printMatrix(matrix);

            Console.Write($"\nNhập chỉ số hàng i cần in (0 đến {rows - 1}): ");
            int rowIndex = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hàng {rowIndex}:");
            printRow(matrix, rowIndex);

            Console.Write($"Nhập chỉ số cột i cần in (0 đến {cols - 1}): ");
            int colIndex = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cột {colIndex}:");
            printColumn(matrix, colIndex);

            Console.WriteLine($"\nGiá trị lớn nhất trong ma trận: {findMaxValue(matrix)}");

            Console.WriteLine($"Giá trị nhỏ nhất trên hàng {rowIndex}: {findMinInRow(matrix, rowIndex)}");
            Console.WriteLine($"Giá trị nhỏ nhất trên cột {colIndex}: {findMinInCol(matrix, colIndex)}");

            Console.WriteLine("\nMa trận chuyển vị:");
            int[,] transposed = transposeMatrix(matrix);
            printMatrix(transposed);

            if (rows == cols)
            {
                Console.WriteLine("\nĐường chéo chính:");
                printMainDiagonal(matrix);
                Console.WriteLine("Đường chéo phụ:");
                printSecondaryDiagonal(matrix);
            }
            else
            {
                Console.WriteLine("\nMa trận vừa nhập không phải ma trận vuông. Tạo thêm một ma trận vuông (3x3) để kiểm tra đường chéo:");
                int[,] squareMatrix = createRandomMatrix(3, 3);
                printMatrix(squareMatrix);
                Console.Write("Đường chéo chính: ");
                printMainDiagonal(squareMatrix);
                Console.Write("Đường chéo phụ: ");
                printSecondaryDiagonal(squareMatrix);
            }
        }
    }
}
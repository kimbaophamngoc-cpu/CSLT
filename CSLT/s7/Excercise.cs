using System;
using System.Text;

namespace CSLT.s7
{
    public class Exercise
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 11);
            }

            Console.WriteLine("--- MẢNG BAN ĐẦU ---");
            PrintArray(arr);
            Console.WriteLine("--------------------\n");

            Console.WriteLine("1. Giá trị trung bình: " + Average(arr));

            int testValue = 5;
            Console.WriteLine("2. Mảng có chứa số " + testValue + " không? " + Contains(arr, testValue));

            int firstElement = arr[0];
            Console.WriteLine("3. Chỉ số (index) đầu tiên của số " + firstElement + " là: " + FindIndex(arr, firstElement));

            int[] removedArr = RemoveElement(arr, firstElement);
            Console.WriteLine("4. Mảng sau khi xóa tất cả số " + firstElement + ":");
            PrintArray(removedArr);

            var maxmin = FindMaxMin(arr);
            Console.WriteLine("5. Giá trị Max: " + maxmin.Item1 + " | Min: " + maxmin.Item2);

            int[] reversedArr = ReverseArray(arr);
            Console.WriteLine("6. Mảng sau khi đảo ngược:");
            PrintArray(reversedArr);

            int[] duplicates = FindDuplicates(arr);
            Console.WriteLine("7. Các giá trị bị trùng lặp trong mảng:");
            PrintArray(duplicates);

            int[] noDuplicates = RemoveDuplicates(arr);
            Console.WriteLine("8. Mảng sau khi xóa trùng (chỉ giữ lại giá trị duy nhất):");
            PrintArray(noDuplicates);
        }


        static void PrintArray(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("(Mảng rỗng)");
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        // 1. Tính giá trị trung bình (Average)[cite: 4]
        static double Average(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }

        // 2. Kiểm tra mảng có chứa giá trị value không (Contains)
        static bool Contains(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        // 3. Tìm vị trí (index) của phần tử đầu tiên xuất hiện (Find Index)
        static int FindIndex(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i; 
                }
            }
            return -1; 
        }

        // 4. Xóa tất cả phần tử có giá trị là value (Remove Element)
        static int[] RemoveElement(int[] arr, int value)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != value)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != value)
                {
                    result[index++] = arr[i];
                }
            }
            return result;
        }

        // 5. Tìm giá trị lớn nhất và nhỏ nhất (Find Max & Min)
        static (int, int) FindMaxMin(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            return (max, min);
        }

        // 6. Đảo ngược mảng (Reverse Array)
        static int[] ReverseArray(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - 1 - i];
            }
            return reversed;
        }

        // 7. Tìm các giá trị xuất hiện từ 2 lần trở lên (Find Duplicates)[cite: 4]
        static int[] FindDuplicates(int[] arr)
        {
            int[] temp = new int[arr.Length];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        bool alreadyAdded = false;
                        for (int k = 0; k < count; k++)
                        {
                            if (temp[k] == arr[i])
                            {
                                alreadyAdded = true;
                                break;
                            }
                        }

                        if (!alreadyAdded)
                        {
                            temp[count++] = arr[i];
                        }
                        break;
                    }
                }
            }

            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }

        // 8. Xóa các phần tử trùng lặp, chỉ giữ lại giá trị duy nhất (Remove Duplicates)
        static int[] RemoveDuplicates(int[] arr)
        {
            int[] temp = new int[arr.Length];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool exists = false;
                for (int k = 0; k < count; k++)
                {
                    if (temp[k] == arr[i])
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    temp[count++] = arr[i];
                }
            }

            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }
    }
}
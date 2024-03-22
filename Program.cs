using System;
using System.Text;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            BaiTap1(arr);
            BaiTap2(arr);
            BaiTap3(arr);
            BaiTap4(arr);
            BaiTap5(arr);
            BaiTap6(arr);
            BaiTap7(arr);
            Console.ReadKey();
        }
        static void BaiTap1(int[] arr)
        {
            Console.WriteLine("===== Đọc và in các phần tử trong mảng =====");
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
        static void BaiTap2(int[] arr)
        {
            Console.WriteLine("===== In mảng dữ liệu theo chiều ngược lại =====");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int num = arr[i];
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
        static void BaiTap3(int[] arr)
        {
            Console.WriteLine("===== Tìm số lượng phần tử giống nhau trong mảng =====");
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] != arr[j]) continue;
                    count++;
                    break;
                }
            }
            Console.Write(count);
            Console.WriteLine();
        }
        static void BaiTap4(int[] arr)
        {
            Console.WriteLine("===== In các phần tử duy nhất trong mảng =====");
            for (int i = 0; i < arr.Length; i++)
            {
                bool isEqual = false;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] != arr[j]) continue;
                    isEqual = true;
                    break;
                }
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] != arr[j]) continue;
                    isEqual = true;
                    break;
                }
                if (isEqual) continue;
                int num = arr[i];
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
        static void BaiTap5(int[] arr)
        {
            Console.WriteLine("===== Chia mảng dữ liệu ban đầu thành mảng chẵn và mảng lẻ =====");
            int[] evenArr = new int[arr.Length];
            int[] oddArr = new int[arr.Length];
            int x = 0;
            int y = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[x] = arr[i];
                    x++;
                }
                else
                {
                    oddArr[y] = arr[i];
                    y++;
                }
            }
            for (int i = 0; i < x; i++)
            {
                int num = evenArr[i];
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            for (int i = 0; i < y; i++)
            {
                int num = oddArr[i];
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
        static void BaiTap6(int[] arr)
        {
            Console.WriteLine("===== Sắp xếp mảng theo thứ tự giảm dần =====");
            static void Swap(ref int a, ref int b)
            {
                int t = a;
                a = b;
                b = t;
            }
            
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] >= arr[i]) continue;
                    Swap(ref arr[i], ref arr[j]);
                }
            }
            foreach (var num in arr)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
        static void BaiTap7(int[] arr)
        {
            Console.WriteLine("===== Tìm kiếm phần tử lớn hơn hai trong mảng dữ liệu ban đầu =====");
            static int MaxValue(int[] arr)
            {
                int maxValue = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (maxValue < arr[i]) maxValue = arr[i];
                }
                return maxValue;
            }
            
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int max;
            max = MaxValue(arr);
            arr = arr.Where(x => x != max).ToArray();
            max = MaxValue(arr);
            Console.WriteLine(max);
            Console.ReadKey();
            
        }
    }
}

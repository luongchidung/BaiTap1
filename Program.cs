using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("So luong phan tử khong hop le.");
                return;
            }

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxElement = arr[0];
            int viTri = 0;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                    viTri = i;
                }
            }

            Console.WriteLine($"Phan tu lon nhat trong mang la {maxElement} va no nam o vi tri {viTri}.");
            Console.Read();
        }
    }
}

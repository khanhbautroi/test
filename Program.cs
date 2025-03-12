using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static bool ktSoChinhPhuong(int so)
        {
            if (so < 0) return false;
            int cb2 = (int)Math.Sqrt(so);
            return cb2 * cb2 == so;
        }

        static void Main(string[] args)
        {
            int[] a;
            int n;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhap so phan tu cua mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap phan tu a[{i}]:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Cac so chinh phuong trong mang la:");
            foreach (int i in a)
            {
                if (ktSoChinhPhuong(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

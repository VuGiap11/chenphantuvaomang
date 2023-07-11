using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace chenphanntuvaomang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("mời nhập vào phần tử n = ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("mời nhập vào giá tri của {0} = ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" nhap gia tri can chen vao mang: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(" moi nhap vao vi tri can chen: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(" mang truoc khi chen phan tu ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
            for (int i = n; i >= k; i--)
            {
                numbers[i] = numbers[i - 1];
                numbers[k-1] = x;
            }
            Console.Write("mang sau khi chen phan tu: ");
            for (int i = 0; i <= n; i++)
            {
                Console.Write("{0} ",numbers[i]);
            }

            Console.ReadKey();  
        }
    }
}

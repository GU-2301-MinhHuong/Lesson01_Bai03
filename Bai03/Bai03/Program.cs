using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int test, n = 0;
            if (x <= 1)
            {
                Console.WriteLine(x + " khong phai so nguyen to");
            }
            else
            {
                for (test = 2; test <= x; test++)
                {
                    if (x % test == 0)
                    {
                        n++;
                    }
                }
                if (n == 1)
                {
                    Console.WriteLine(x + " la so nguyen to");
                }
                else
                {
                    Console.WriteLine(x + " khong phai so nguyen to");
                }
            }
            Console.ReadKey();
        }
    }
}

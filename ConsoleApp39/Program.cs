using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {//4.
            int n, k;
            Console.Write("Tell me y = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tell me x =");
            k = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i<=n)
            {
                int j = 1;
                while (j<=k)
                {
                    Console.Write("*");
                    j++;
                }
                
                Console.WriteLine(" ");
                i++;
            }
            
            Console.ReadKey();
        }
    }
}

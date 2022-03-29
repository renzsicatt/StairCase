using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input height: ");
            int size = Convert.ToInt32(Console.ReadLine());
            print(size);
            Console.ReadKey();
        }
        static void print(int size)
        {
            for(int x = size-1; x>= 0; x--)
            {
                for(int j = 0; j<=size; j++)
                {
                    if (j > x)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }


    }
}

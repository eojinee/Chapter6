using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapByValue
{
    class MainApp
    {
        public static void Swap(ref int a, ref int b, ref int c)
        {
            int temp = b;
            b = a;
            a = temp;
            c = b;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int z = 5;
            Console.WriteLine($"x : {x},y : {y} , z : {z} ");

            Swap(ref x, ref y, ref z);

            Console.WriteLine($"x : {x},y : {y}, z : {z}");

        }
    }
}

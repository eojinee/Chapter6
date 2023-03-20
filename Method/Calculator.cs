using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Calculator
    {
        public static int Plus(int a , int b)
        {
            return a + b;
        }
        public static int Minus(int a , int b)
        {
            return a - b;

        }
        class MainApp
        {
            public static void Main()
            {
                int result = Calculator.Plus(3, 4); //calculator에있는 plus를 3이랑 4에적용시킵니다
                Console.WriteLine(result);

                result = Calculator.Minus(5, 2);
                Console.WriteLine(result);
            }
        }
        
       
        }
    }


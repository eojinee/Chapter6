using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingParams_
{
    class MainApp
    {
        static int Sum(params int[] args) 
        {
            Console.Write("Summing...");

            int sum = 0; // sum 이라는 공간에 0생김

            for (int i = 0; i < args. Length; i++)   // 0.0(1회용)    1            i++가 3번
                {              //여기서부터
                if (i > 0)                     //i가 0보다 클때~
                    Console.Write(", ");      

                Console.Write(args[i]);

                sum += args[i]; // 0+3 =3

            }                  //여기까지 2번
            Console.WriteLine();
            return sum;

        }
        static void Main(string[] args) // args : 배열이라는 뜻 지금은 8개의 공간 생김 이제 11라인으로 ~
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10); //현재 sum 이라는 변수가 만들어짐 3~10을 넘김

            Console.WriteLine($"Sum : {sum}");

        }
    }
}

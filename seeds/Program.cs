using System;
using System.Threading;

namespace seeds
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, joy = 0, carlson = 0;
            Console.WriteLine("Who is your favourite Studio lecturer");
            joy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(joy);
            Thread.Sleep(1000);

            if (joy == 1)
            {
                Console.WriteLine("That is absolutely correct");
            }

            if (joy <= 0) {
                Console.WriteLine("that is an absolute crime");
                    }

            Console.ReadLine();
            count++;
            carlson = -10;
            Console.WriteLine("enter the scale of hardness for sand test, 1 - DUMB");
            string dumbness = Console.ReadLine();
            Console.WriteLine("IT DOESNT MATTER WHAT YOU THINK CAUSE IT WAS JUST DUMB");
            Console.WriteLine("I HATE SAND -ANAKIN SKYWALKER");



            Console.WriteLine("Hello World!");



        }
    }
}

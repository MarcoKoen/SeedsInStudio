using System;

namespace seeds
{
    class Program
    {
        static void Main(string[] args)
        {
            int Height;


            Console.WriteLine("Please enter your height.");
            Height = Convert.ToInt32(Console.ReadLine());

            if (Height > 170)
            {
                Console.WriteLine("Hello, daddy long leg.");
            }
            else if (Height == 183)
            {
                Console.WriteLine("Yooo Caleb,");
            }
            else
            {
                Console.WriteLine("Supp tiny.");
            }
            Console.ReadLine();
        }
    }
}

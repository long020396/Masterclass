using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 / d2;

            float f1 = 3.5F;


            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);
            Console.WriteLine("The sum of {0} and {1} is {2}", d1, d2, sumD);
            Console.Read();
        }
    }
}

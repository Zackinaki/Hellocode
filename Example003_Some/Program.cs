using System;

namespace Example003_Some
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = new Random().Next(1,10); //1..9
            Console.WriteLine(numberA);
            int numberB = new Random().Next(1,10);
            Console.WriteLine(numberB);
            int result = numberA + numberB;
            Console.WriteLine(result);


        }
    }
}

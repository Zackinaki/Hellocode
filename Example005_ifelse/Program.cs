using System;

namespace Example005_ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vvedite ima usera: ");
            string username = Console.ReadLine();

            if(username.ToLower() == "masha")
            {
                Console.WriteLine("Ura!!!, Masha");
            }
            else
            {
                Console.Write("Hi, ");
                Console.WriteLine(username);
            }
        }
    }
}

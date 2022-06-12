using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("It is a even number.");
            }

            else
            {
                Console.WriteLine("It is a odd number.");
            }
        }





    }
    


    
    
}

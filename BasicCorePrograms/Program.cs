using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividend;
            int divisor;
            Console.WriteLine("Enter the Dividend value :");
            dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Divisor value :");
            divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;


            Console.WriteLine("Quotient : {0}", quotient);
            Console.WriteLine("Remainder : {0}", remainder);
        }





    }
    


    
    
}

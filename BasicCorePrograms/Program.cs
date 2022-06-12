using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs");
            Console.WriteLine(" Please enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            float sum = 0;
            for (float i = 1; i <= n; i++)
            {
                sum = sum + (1 / i);
            }
           

            Console.WriteLine("harmonic mean upto " + n + " = " + sum);
        }





    }
    


    
    
}

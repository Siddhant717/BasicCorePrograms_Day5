using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Find the largest among three numbers-");
            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("1st is the largest number.");

            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("2nd is the largest number.");
            }
            else
            {
                Console.WriteLine("3rd is the largest number.");
            }
        }
    }


}
    


    
    


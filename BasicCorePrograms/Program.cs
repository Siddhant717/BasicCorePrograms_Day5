using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs");

            int Flip = 100;
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;



            if (Flip > 0)
            {
                for (int i = 1; i <= Flip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(0, 2);
                    Console.WriteLine(number);



                    switch (number)
                    {
                        case 0:
                            TailCount++;
                            break;
                        case 1:
                            HeadCount++;
                            break;
                    }


                }
                Console.WriteLine("--------------");
                HeadPercentage = (HeadCount * 100) / Flip;
                TailPercentage = (TailCount * 100) / Flip;

                Console.WriteLine("Head Percentage : " + HeadPercentage);
                Console.WriteLine("Tail Percentage : " + TailPercentage);

            }
            else
            {
                Console.WriteLine("Enter a Positive Integer");
            }

        }
    }
}

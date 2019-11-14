using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{

    class Utility
    {

        public static void Continue()
        {

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Hit enter to continue...");
                Console.WriteLine();

                var end = Console.ReadLine();

                if (end != null)
                {
                    break;
                }

            } // end of while

        } // end of method 

    } // end of class 


    public static void Main()
    {
        List<int> numbers = new List<int>();

        int number = 7;

        for (int i = 0; i < number; i++)
        {
            if (i == 0 || i == 6)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            if (i >= 1 && i <= 5)
            {
                for (int j = 0; j < number; j++)
                {
                    if (j == 0 || j == 6)
                    {
                        Console.Write("*");
                    }
                    else if (j >= 1 && j <= 5)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

                Console.WriteLine("WELCOME TO THE NUMBER SORTER");
                Console.WriteLine("┌───────────────────────────┐");
                Console.WriteLine("│Jen's Magical number sorter│");
                Console.WriteLine("└───────────────────────────┘");
                Console.WriteLine("┌───────────────────────────┐");
                Console.WriteLine("│Made 2016, update 2018     │");
                Console.WriteLine("└───────────────────────────┘");
                Console.WriteLine();
                Console.WriteLine("Enter '0' to stop and sort numbers.");

                Utility.Continue();

                Console.WriteLine("Enter a number:");

                int input = Convert.ToInt32(Console.ReadLine());

                numbers.Add(input);


                while (true)
                {

                    if (input == 0)
                    {

                        Utility.Continue();
                        var sort = numbers.OrderBy(i => i).ToList();
                        sort.Remove(0);

                        foreach (var x in sort)
                        {
                            Console.WriteLine(x);
                        }

                        goto end;
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter another number:");
                        input = Convert.ToInt32(Console.ReadLine());
                        numbers.Add(input);
                        continue;
                    }


                }


            end:;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("FINISHED COMPUTATIONS...");

            }
        }
    }
}

    }
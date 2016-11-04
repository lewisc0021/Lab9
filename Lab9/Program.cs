using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Circle Tester");
            int count = 0; // Counts the number of circles
            while (true)
            {//+PRIMARY LOOP START
                double radius;

                while (true)
                {//*
                    Console.WriteLine("Enter the radius of your circle.");
                    while (!double.TryParse(Console.ReadLine(), out radius))
                    {
                        Console.WriteLine("Please enter a correct value.");
                    }
                    if (radius > 0) break;
                    else
                    {
                        Console.WriteLine("Please enter a positive value");
                    }
                }//*

    
                Circle Circle1 = new Circle(radius);
                Console.WriteLine($"Circumference: {Circle1.getFormattedCircumference()}");
                Console.WriteLine($"Area: {Circle1.getFormattedArea()}");
                count++;//Increments the number of circles
          

                string answer;
                while (true)
                {//?          
                Console.WriteLine("Continue? (y/n)");
                answer = Console.ReadLine().Trim().ToLower();
                if (answer == "")
                {
                Console.WriteLine("Please actually enter a value.");
                continue;
                }
                if (!(answer == "y" || answer == "n" ))
                Console.WriteLine("What? Enter again.");
                else
                break;
                }//?


                if (answer == "n")
                {
                    Console.WriteLine();
                    Console.WriteLine($"You've created {count} object(s)");
                    break;
                }


            }//+PRIMARY LOOP STOP

        }//MAIN
} }//END-------------------------------------------------------------------------------------END

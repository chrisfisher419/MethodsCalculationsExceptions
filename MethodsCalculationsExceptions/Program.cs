using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MethodsCalculationsExceptions
{
    class CalculateAll
    {



        static void Main(string[] args)
        {

            Calculate1();
            Calculate2();
            Calculate3();
        }




        static void Calculate1()
        {
            try
            {
                Console.WriteLine("I am a magical wizard who will calculate the compounding interest of your $6000 tuition over 5 years!");
                Console.ReadLine();
                Console.WriteLine("For year 1, your tuition will be $6000, because there's no increase on your first year!");
                Console.ReadLine();

                double year;
                for (year = 1; year <= 4; year++)
                {
                    double rate = 6000;
                    double increase = 0.02;
                    double body = 1 + (increase / 1);
                    double exponent = 1 * year;
                    double amount = rate * Math.Pow(body, exponent);
                    Console.WriteLine($"For year {year + 1} your tuition will be ${amount}");
                    Console.ReadLine();
                    Console.WriteLine();

                }
                Console.WriteLine("Now enter those numbers here to find the total cost for 5 years! OR press 0 to skip and move on");
                double year1 = Convert.ToDouble(Console.ReadLine());
                if (year1 == 0)
                {
                    Calculate2();
                }
                checked
                {
                    double year2 = Convert.ToDouble(Console.ReadLine());
                    double year3 = Convert.ToDouble(Console.ReadLine());
                    double year4 = Convert.ToDouble(Console.ReadLine());
                    double year5 = Convert.ToDouble(Console.ReadLine());
                    double total = year1 + year2 + year3 + year4 + year5;
                    Console.WriteLine($"Your total will be ${total}");
                    Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You did something wrong here, now you have to start over...");
                Console.ReadLine();
                Calculate1();
            }

        }





        static void Calculate2()
        {
            Console.WriteLine("Now I will magically convert feet to inches! [Press enter to continue]");
            Console.ReadLine();
            try
            {
                checked
                {
                    double feet;
                    double inches;
                    Console.WriteLine("Enter the number of feet");
                    feet = Convert.ToDouble(Console.ReadLine());
                    if (feet < 0)
                    {
                        throw new FormatException("Less than zero!");

                    }
                    inches = feet * 12;
                    Console.WriteLine($"{feet} feet is {inches} inches! Enter 0 to move on, or anything else to try again ");
                    string input = Console.ReadLine();
                    if (input == "0")
                    {
                        Calculate3();
                    }
                    else
                    {
                        Calculate2();
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid input! Now you have to try again....");
                Console.ReadLine();
                Calculate2();
            }

        }




        static void Calculate3()
        {
            Console.WriteLine("Now, enter two numbers and I will determine which is greater!");
            try
            {
                checked
                {

                    double input1 = Convert.ToDouble(Console.ReadLine());
                    double input2 = Convert.ToDouble(Console.ReadLine());
                    if (input1 > input2)
                    {
                        Console.WriteLine("The first number is greater");
                        Console.ReadLine();

                    }
                    else if (input2 > input1)
                    {
                        Console.WriteLine("The second number is greater");
                        Console.ReadLine();

                    }
                    else if (input1 == input2)
                    {
                        Console.WriteLine("They are equal, couldn't you tell?");
                        Console.ReadLine();

                    }
                }
                Console.WriteLine("Want to try again?, enter 1 to try again, 0 to start over from the very beginning, or enter anything else to exit");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Calculate3();
                }
                else if (input == "0")
                {
                    Calculate1();
                }
                else
                {

                    Console.WriteLine("Good day!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Input a number, silly [Press Enter To Try Again]");
                Console.ReadLine();
                Calculate3();
            }

            finally
            {
                Console.WriteLine("This is just for show, you should never reach this");
            }

        }

    }
}

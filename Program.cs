/*
 *    Author:     Christopher Lopez
 *    Course:     COMP-003A
 *    Purpose:    Code for Assignment4
 */
namespace COMP003A.Assignment4
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // For Loop Section 
                Console.WriteLine("***************************************************");
                Console.WriteLine("for loop section");
                Console.WriteLine("output a right triangle based on user input");
                Console.WriteLine("***************************************************");
                Console.Write("Enter a positive whole number: ");
                int limit = Convert.ToInt32(Console.ReadLine());
                string output = "#";

                for (int i = 0; i < limit; i++)
                {
                    Console.WriteLine(output);
                    output += "#";
                }
                Console.WriteLine("");
                Console.WriteLine("");
                // For Each Section (Friends)
                string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

                Console.WriteLine("***************************************************");
                Console.WriteLine("foreach section");
                Console.WriteLine("output all of the friends in an array");
                Console.WriteLine("***************************************************");
                foreach (string friend in friends)
                {
                    Console.WriteLine(friend);
                }
                Console.WriteLine("");
                Console.WriteLine("");

                // Do-While Loop Section (Counting by 5s)
                int counter = 0;

                Console.WriteLine("***************************************************");
                Console.WriteLine("do-while section");
                Console.WriteLine("output 0-50 by 5s");
                Console.WriteLine("***************************************************");
                do
                {
                    Console.WriteLine(counter);
                    counter += 5;
                } while (counter <= 50);
                Console.WriteLine("");
                Console.WriteLine("");

                // While Loop Section (FooBar)
                int counter2 = 1;

                Console.WriteLine("***************************************************");
                Console.WriteLine("while section");
                Console.WriteLine("output 1-20");
                Console.WriteLine("if the number is divisible by 2, output Foo");
                Console.WriteLine("if the number is divisible by 5, output Bar");
                Console.WriteLine("if the number is divisible by 2 & 5, output FooBar");
                Console.WriteLine("***************************************************");
                while (counter2 <= 20)
                {
                    if (counter2 % 2 == 0 && counter2 % 5 == 0)
                    {
                        Console.WriteLine("FooBar");
                    }
                    else if (counter2 % 2 == 0)
                    {
                        Console.WriteLine("Foo");
                    }
                    else if (counter2 % 5 == 0)
                    {
                        Console.WriteLine("Bar");
                    }
                    else
                    {
                        Console.WriteLine(counter2);
                    }

                    counter2++;
                }
            }
        }
    }

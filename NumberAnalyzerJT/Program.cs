using System;

//The application prompts the user to enter an integer between 1 and 100.
//Display the associated result based on the integer range entered


namespace NumberAnalyzerJT
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello. Welcome to the Number Analyzer Program. Please enter your username to get started.");
            string name = Console.ReadLine();
            
            bool Start = true; //Starting Loop to restart program
            while (Start)
            {
                Console.WriteLine("Alright {0}, please enter an integer between 1 to 100.", name);
                int a = Convert.ToInt32(Console.ReadLine()); //saving user integer input as "a"

                        for (int i = 1; i <= a; i++) ; //?
                        {
                            if (a % 2 == 0 && a >= 2 && a < 25) //a is even and and 2 <= a <= 24
                            {
                                Console.WriteLine("Your number {0} is Even and less than 25,", a);
                                Console.WriteLine(name);

                            }
                            else if (a % 2 == 0 && a >= 26 && a <= 60) //if a is even and 26 <= a <= 60
                            {
                                Console.WriteLine("{0} is Even and between 26 and 60 inclusive.", a);
                            }
                            else if (a % 2 == 0 && a > 60) // if a is EVEN and a > 60
                            {
                                Console.WriteLine("{0} is Even and greater than 60", a);
                            }
                            else if (a > 60) //if a is ODD and a > 60
                            {
                                Console.WriteLine("The number {0} is Odd and greater than 60.", a);
                            }
                            else // if a is ODD and is < 60
                            {
                                Console.WriteLine("The number {0} is Odd and less than 60.", a);
                            }

                        }
                        bool askAgain = true;//Loop to repeat restart/exit prompt
                        while (askAgain)
                        {
                            Console.WriteLine("Would you like to restart the program {0}? Y/N", name);
                            string input = Console.ReadLine().ToLower();
                            if (input == "y")
                            {
                                Start = true; //yes to restart program
                                askAgain = false; //no to ask to restart
                            }
                            else if (input == "n")
                            {
                                Start = false; //no to restart program
                                askAgain = false; //no to ask to restart
                            }
                            else //if user input is not "y" or "n"
                            {
                                Console.WriteLine("I'm sorry {0}, I'm afraid I can't do that. Please try again.", name);
                                askAgain = true;
                            }
                        }           
            }                 
        }
    }
}

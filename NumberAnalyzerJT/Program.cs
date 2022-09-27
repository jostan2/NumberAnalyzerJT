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
            string name = Console.ReadLine(); //saving username as "name"
            
            bool Start = true; //Start of loop to restart program
            while (Start)
            {
                    Console.WriteLine("Alright {0}, please enter an integer between 1 to 100.", name);
                        var numcheck = int.TryParse(Console.ReadLine(), out int a); //numcheck = if-statement checking if "a" is a number between 1-100, and not a character or other invalid response.
                
                if (numcheck == false) //if "a" is not a number
                {
                    Console.WriteLine("I'm sorry {0}, I'm afraid I can't do that. That is not a number. Please try again.", name);
                    Console.WriteLine();
                }
                else if (numcheck == true && a < 1 || a > 100) //if "a" is a number, but is not within the range of 1-100
                {
                    Console.WriteLine("I'm sorry {0}, I'm afraid I can't do that. That is not a number between 1 and 100. Please try again.", name);
                    Console.WriteLine();
                }
                else
                {
                      for (int i = 1; i <= a; i++) ; //?
                      {
                        if (a % 2 == 0 && a >= 2 && a < 25) //a is EVEN and and 2 <= a <= 24
                        {
                          Console.WriteLine("{0}, your number {1} is Even and less than 25,", name, a);
                          Console.WriteLine();
                        }
                        else if (a % 2 == 0 && a >= 26 && a <= 60) //if a is EVEN and 26 <= a <= 60
                        {
                          Console.WriteLine("{0}, your number {1} is Even and between 26 and 60 inclusive.", name, a);
                            Console.WriteLine();
                        }
                        else if (a % 2 == 0 && a > 60) // if a is EVEN and a > 60
                        {
                          Console.WriteLine("{0}, your number {1} is Even and greater than 60", name, a);
                            Console.WriteLine();
                        }
                        else if (a > 60) //if a is ODD and a > 60
                        {
                          Console.WriteLine("{0}, your number {1} is Odd and greater than 60.", name, a);
                            Console.WriteLine();
                        }
                        else // if a is ODD and is < 60
                        {
                         Console.WriteLine("{0}, your number {1} is Odd and less than 60.", name, a);
                          Console.WriteLine();
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
                          Console.WriteLine();
                        }
                      }
                
                }
            }
          
        }                 
    }
}



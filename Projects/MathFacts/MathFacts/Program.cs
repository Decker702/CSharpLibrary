using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Program
    {
        static void Main(string[] args)
        //with static you don't need an instance to use a method

        {
            Console.Title = "Math Facts App";
            int choice = 0;
            Addition addTable = new Addition();
            Multiplication timesTable = new Multiplication();
            do
            {
                MainAppTitle();
                choice = MainMenu();
                if (choice == 1)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        addTable.AdditionTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();
                        }
                        finally
                        {
                            if (startNum > 0 && endNum <= 10)
                            {
                                addTable.AdditionTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Your addition Table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                addTable.AdditionTable(startNum, endNum);
                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you like more additon facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter y or n");
                                }
                            }
                        }

                    } while (continueChoice == true);
                }

                //Multiplication portion
                if (choice == 2)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        timesTable.MultiplicationTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();
                        }
                        finally
                        {
                            if (startNum > 0 & endNum <= 10)
                            {
                                timesTable.MultiplicationTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your Multiplication Table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                timesTable.MultiplicationTable(startNum, endNum);
                                Console.WriteLine("");

                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you like more multiplication facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter y or n");
                                }
                            }
                        }
                    } while (continueChoice == true);
                }
            } while (choice != 3);
        }

        private static int MainMenu()
        {
            int choice;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select an option");
            Console.WriteLine("-----------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Option 1: Addition Facts");
            Console.WriteLine("Option 2: Multiplication Facts");
            Console.WriteLine("Option 3: Leave Math Facts");
            //TODO - fix the exception handling
            choice = Int32.Parse(Console.ReadLine());
            return choice;
        }

        private static void MainAppTitle()
        {
            Console.Clear();
            string appTitle = @"

 _ _ _                 _____                 __        
' ) ) )     _/_ /       /  '      _/_       /  )       
 / / / __.  /  /_    ,-/-,__.  _. /  _     /--/ _   _  
/ ' (_(_/|_<__/ /_  (_/  (_/|_(__<__/_)_  /  (_/_)_/_)_
                                              /   /    
                                             '   '    ";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
/*
static void Main(string[] args)

{
    Console.Clear(); //clears screen between selections
    //Change the state of the applications.
    // Initial state - menu, then 3 items are other states(choices)
    //First - Build a title
    Console.Title = "Math Facts App";
    int choice = 0;
    Addition addTable = new Addition();
    //Do While Loop
    do
    {
        NewMethod(); //this is the ascii art file
        choice = NewMethod1();// this is the main menu
        if (choice == 1)
        {
            bool continueChoice = true;
            int startNum = 0;
            int endNum = 0;
            do
            {
                addTable.AdditionTable();
                try
                {
                    Console.WriteLine("Enter your stating number.");
                    startNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your ending number.");
                    endNum = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.ReadLine();
                    break;
                }
                finally
                {
                    if (startNum > 0 && endNum <= 10)
                    {
                        addTable.AdditionTable();
                        Console.WriteLine("");//to add a space
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Your Addition Table for {0} to {1}", startNum, endNum);
                        Console.WriteLine("");
                        addTable.AdditionTable(startNum, endNum);

                        Console.WriteLine("");
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Would you like more addion facts? [y/n]");
                            Console.ForegroundColor = ConsoleColor.White;
                            string moreFacts = Console.ReadLine();
                            if (moreFacts == "y")
                            {
                                continueChoice = false;
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                    //Build logic to handle addition table
                    //build logic to allow user to continue or end addition
                    //Console.WriteLine("Hey you did it");
                    //Console.ReadLine();
                    //continueChoice == false;

                }

            } while (continueChoice == true);
        }
        if (choice == 2)
        {
            bool continueChoice = true;
            int startNum = 0;
            int endNum = 0;
            do
            {

            }while ()
        }

            //Console.ReadLine();
            //break;

            //Learned to refractered by extracting it to a helper method
        } while (choice != 3) ;//this is available to everthing in here
                               //above lets menu continue as long as don't enter 3.
//When choice equals 3, then it is false & ends.


    }
private static int NewMethod1()
{
    int choice;
    Console.WriteLine("Select an option");
    Console.WriteLine("-----------------");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Option 1: Addition Facts");
    Console.WriteLine("Option 2: Multiplication Facts");
    Console.WriteLine("Option 3: Leave Math Facts");
    choice = Int32.Parse(Console.ReadLine());
    return choice;
}

private static void NewMethod()
{
    string appTitle = @"
8888ba.88ba             dP   dP           88888888b                     dP            
88  `8b  `8b            88   88           88                            88            
88   88   88 .d8888b. d8888P 88d888b.    a88aaaa    .d8888b. .d8888b. d8888P .d8888b. 
88   88   88 88'  `88   88   88'  `88     88        88'  `88 88'  `""   88   Y8ooooo. 
88   88   88 88.  .88   88   88    88     88        88.  .88 88.  ...   88         88 
dP   dP   dP `88888P8   dP   dP    dP     dP        `88888P8 `88888P'   dP   `88888P' 


.d888888                    
d8'    88                    
88aaaaa88a 88d888b. 88d888b. 
88     88  88'  `88 88'  `88 
88     88  88.  .88 88.  .88 
88     88  88Y888P' 88Y888P' 
   88       88       
   dP       dP       ";
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(appTitle);

}
}

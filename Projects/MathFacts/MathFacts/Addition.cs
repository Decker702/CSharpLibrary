using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Addition
    {
        public void AdditionTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @"
   __                            ______      _  
  /  )   /   /  _/_                /     /  //  
 /--/ __/ __/ o /  o __ ____    --/__.  /__// _ 
/  (_(_/_(_/_<_<__<_(_)/ / <_  (_/(_/|_/_)</_</_
                                                ";
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You can select a starting number and an ending number between 1 - 10.");
            Console.WriteLine("Then you will see the numbers between your selections be added");
            Console.WriteLine("to numbers 1 - 10");
            Console.WriteLine("");
            Console.WriteLine("Select a starting number between 1 and 10");
        }

        public void AdditionTable(int startNum, int endNum)
        {
            for (int i = startNum - 1; i <= endNum; i++)
            {
                if (i == startNum - 1)
                {
                    Console.Write(String.Format("{0, 6}", "n"));
                }
                else
                {
                    Console.Write(String.Format("{0,6}", i));
                }

            }

            Console.WriteLine("\n");


            for (int i = 1; i <= 10; i++)
            {
                Console.Write(String.Format("{0, 6}", i));
                for (int b = startNum; b <= endNum; b++)
                {
                    string output = String.Format("{0, 6}", i + b);
                    Console.Write(output);
                }
                Console.WriteLine("");
            }


        }
    }
}

/*
public void AdditionTable()

{
    Console.Clear(); //has to be inside a me .d888888        dP       dP oo   dP   oo                   
    Console.ForegroundColor = ConsoleColor.DarkRed;
    string appTitle = @" .d888888        dP       dP oo   dP   oo                   
d8'    88        88       88      88                        
88aaaaa88a .d888b88 .d888b88 dP d8888P dP .d8888b. 88d888b. 
88     88  88'  `88 88'  `88 88   88   88 88'  `88 88'  `88 
88     88  88.  .88 88.  .88 88   88   88 88.  .88 88    88 
88     88  `88888P8 `88888P8 dP   dP   dP `88888P' dP    dP 


d888888P          dP       dP          
88             88       88          
88    .d8888b. 88d888b. 88 .d8888b. 
88    88'  `88 88'  `88 88 88ooood8 
88    88.  .88 88.  .88 88 88.  ... 
dP    `88888P8 88Y8888' dP `88888P' ";
    Console.WriteLine(appTitle);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("The starting and ending numbers are between 1 and 10.");
    Console.WriteLine("Next you will see the numbers between these numbers added");
    Console.WriteLine("");
    Console.WriteLine("Select a starting number between 1 and 10"); 
   // Console.ReadLine();
}
public void AdditionTable(int startNum, int endNum)
{
    //TODO - build out the logic of the addition table here.
    for (int i = startNum - 1; i <= endNum; i++)
    {
        //using Write to get them to be side by side.  
        Console.Write(String.Format("{ 0, 6}", n));
    }
    else
    {
        Console.Write(String.Format("{0, 6}", i));
    }
    Console.WriteLine("");

    for (int i = 1; i < 10; i++)
    {
        Console.Write(String.Format("{0, 6}"));
        for (int b = startNum; b <= endNum; b++);

        {
            string output = String.Format("{0, 6}");
            Console.Write(output);
        }
        Console.WriteLine("");
    }
}
}
}
*/
using System;//Using statements bring in already created/defined code to simplify your coding
//Can add a using space by hovering and hitting control = .

namespace _0._01_Intro //Namespace is a container of related classes.
         //It has acces to the Classes it contains.  
         //The using statments provide additional information to the namespace.

{
    class Program//Classes start with a capital letter.
        //Classes are the building blocks, which contain data and/or methods

    {
        static void Main(string[] args)//The Main method/function is how your program is entered by CLR & it is capitalized.
            //Within the () are the parameters. The () can, but doesn't have to contain parameters  -- it is optional.
            //Parameters are input and output.
            //void means this method does not return any value, just contains code.

        {//The information between {} are separate blocks of code.

           Console.WriteLine("Hello World");// A ; ends every statement.
           Console.ReadLine();//Displays Hello World in the console.
        }
    }
}
//Run application with control + F5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes
{
    class Program//Words in blue are key words
    {
        static void Main(string[] args)
        {
            
            int i = 0;          // implicit conversion, too, a.k.a. Int32
            short sh = 32767;   // 2^16, or 32768, or +/- 0-32767, a.k.a. Int16
            byte by = 255;      // 2^8, or 256, or +/- 0-255, a.k.a. Byte
            string s = "hey!";  // up to 2 gigs in size, or 2^32 bytes, or Int32.MaxValue, a.k.a. String encolded in double "
            char c = 'i';       // a string is just a linked list of chars, note the single quotes, a.k.a. Char
            var s2 = @"a \tree";//variable ; allows the compiler to determine if it should be a type of number or string.
            var s3 = "a \tree"; //varible has to be initialized.
            bool b = false;     // 1 = true, 0 = false, a.k.a. Boolean
            long l = 7;         // long int, 64-bit, a.k.a. Int64
            decimal p;          // 128-bit precision decimal, very expensive, a.k.a. Decimal
            double d = 7.80;    // 64-bit decimal, a.k.a. Double is the default data type for real numbers.
            float f = 10.8f;    // floating point integer, must put f *explicit* conversion afterwards
                                //if using a constant, or you could cast as (float)
            decimal dd = 7.80m; // must add the m if using a constant, or you could cast as (decimal)
            int? ni = null;     // nullable variables, use .HasValue to determine if they are populated, 
                                //useful with web services, database results

            /* C# Primitive Types
            Integral Numbers are: byte, short, int, long
            Real Numbers are: float, decimal & double
            Character is char   Unicode Characters
            Boolean is boo      true/false
             */

            /*C# Non Primitive Types
             String
             Array
             Enum
             Class
             */

            //Declaration Only
            int number;
            string name;
            bool isValid;

            //Declarartion and Initialization
             int year = 2017;
             string country = "United States of America";
           // var year = 2017;  When you use var and intitialize it - the C# compiler determines the type.  
            //var country = "United States of America";  These are another way to write what is above - int & string.

            //Using Console.WriteLine
            Console.WriteLine(s2);
            Console.WriteLine("i = {0}, sh = {1}, i, sh"); //Counting starts at 0
            Console.WriteLine(i + sh);

            //Use this to get console to pop up and stay
            Console.ReadLine();
            
            /*
             * 
             * 
             * 
             */
            
       
        }
    }
}
//CW tab - will write out Console.WriteLine
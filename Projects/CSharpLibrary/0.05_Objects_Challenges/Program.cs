using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Objects_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bronze: Add a class called Hotel.  
             * Create 3 properties/variables: RoomNumber, IsAvailable; NumBeds
             * Create an object and give each property a value
             
            Silver: Create a method that prints our the room number for a guest.
            */
            /*
            Hotel beachHotel = new Hotel();
                beachHotel.RoomNumber = 7;
                beachHotel.IsAvailable = false;
                beachHotel.NumBeds = 2;
            Console.WriteLine("Your room number is " + beachHotel.RoomNumber +".");
            Console.ReadLine();
            */

            /*Gold: Check the availability of a room and prints out -
             * Yes, room 7 is available.  If it is
             * I'm sorry the room is not available.  It is not
             */

            Hotel beachHotel = new Hotel();
            beachHotel.RoomNumber = 7;
            //beachHotel.IsAvailable = true;
            beachHotel.IsAvailable = false;
            beachHotel.NumBeds = 2;

            if (beachHotel.IsAvailable)
            {
                Console.WriteLine("Yes, Room A23 is available.");
            }
            else
            {
                Console.WriteLine("I'm sorry, that room is not available.");
            }

            Console.ReadLine();


        }
    }
}

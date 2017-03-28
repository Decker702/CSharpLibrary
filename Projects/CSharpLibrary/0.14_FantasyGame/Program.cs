using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hard code -- Player player = new Player("JSWizard", "FreshNeverFades");
            //Below allows player to identify themself
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("You are part of which clan?");
            string clan = Console.ReadLine();
            Console.WriteLine("What is your player type?" +
                "0: Assasin\n" +
                "1: Blitzen Blooper\n" +
                "2: Professor\n" +
                "3: Horse Mange\n" +
                "4: Tax Man\n" +
                "5: Human");
            int playerType = int.Parse(Console.ReadLine());

            Player player = new Player(name, clan);
            player.ChooseType(playerType);


            // Below were used with the hard coded Player
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

           // Console.WriteLine(player.CurrentPower);
            //player.PowerLevelCheck();

            Console.WriteLine(player.ToString());
            LizardDog lizardDog = new LizardDog();
            lizardDog.Insult();

           // Enemy Quagga = new Enemy();

           // Quagga.Insult();

            //create a new subclass of enemy (can be any name) that inherits from the enemy class
            //Has a constructor and one method
          
            Console.ReadLine();

        }
    }
}

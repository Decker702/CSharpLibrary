using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //adding the speech synthesizer, an assembly reference
           // SpeechSynthesizer talkingConsole = new SpeechSynthesizer();
            //talkingConsole.Speak("What is your name?");



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

            //This While loop will run until reaches a case where told to stop
            //Like what is done in a switch statement
               
            while (true)
            {
                lizardDog.Insult();
                Console.WriteLine("Do you want to fight? y/n");
                string userAnswer = Console.ReadLine();
                if(userAnswer == "y")
                {
                    lizardDog.LizardAttack(player);
                    if (player.CurrentPower <= 0)
                    {
                        Console.WriteLine("Oh you dead");
                        break;
                    }
                }
                else
                {
                    break;
                }
                break;
                }

            Console.WriteLine(player.CurrentPower);
            lizardDog.LizardAttack(player);
            //Console.WriteLine("This is a new attack");
            Console.WriteLine(player.CurrentPower);
            Console.WriteLine("This is a new attack");
            lizardDog.LizardAttack(player);
            Console.WriteLine(player.CurrentPower);
           // Enemy Quagga = new Enemy();
           // Quagga.Insult();
           //create a new subclass of enemy (LizardDog) that inherits from the enemy class
           //Has a constructor and one method

            Console.ReadLine();

        }
    }
}

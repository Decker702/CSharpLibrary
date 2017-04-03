using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    abstract class Enemy
        //abstract protects the class, won't let others create enemy from this class.
    {
        //calls in the method, created in the class - so can be used by all subclasses (LizardDog)
        protected ArrayList insult = new ArrayList { "buck-o", "wimp", "window licker", "noob", "nerd cakes", "buster" };
        // to add to an ArrayList use -  insult.Add ("four-eyes");
        //Arrays can not expand in size, an array list can.  Dynamically add things.  Depends on memory, which to use.
        protected Random rnd = new Random();
        //protected allows it to be inherited by children/subclasses

        public string Name { get; set; }
        public int PowerLevel { get; set; }

        //create an insult method with a few insults and can be over ridden.
        //virtual in the parent allow it to be overridden by the child
        public virtual void Insult()
        {
          
            int r = rnd.Next(insult.Count);

            Console.WriteLine("You are on the wrong side of the forest {0}", insult[r]);
        }

        // all enemies can attack, Need to know who attacking
        //This method will get called on Enemy
        //this is the class and variable name - it is customized type, to allow
        // you to get the information for that specific player
        //this allows for a named (not generic) player to be attacked
        public void Attack(Player player, Dictionary<string, int> dict, Object enemyName)
        {
            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            //above - used var to allow the compiler to handle the type (string, int).
            //becasue dictionary is dynamic.
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;
        
            Console.WriteLine("{2} is attacking with {0} and deals {1}", attackName, attackVal, enemyName);

            Console.WriteLine("{0} power was {1}%", player.PlayerName, player.CurrentPower);
            player.CurrentPower -= attackVal; 
            // player.CurrentPower = player.CurrentPower  - attackVal

        }
        //   int attackVal = singleAttack.Value;
        //     string attackName = singleAttack.Key;

//   Console.WriteLine("{2} is attacking with {0} and deals {1}", attackName, attackVal, enemyName);

//This attack method goes to Program to LizardDog.Attack(player);
//   Console.WriteLine("{0} power is at {1}%", player.PlayerName, player.CurrentPower);
// player's power decreases during attacks, need assigh & track it
//player.CurrentPower -= attackVal; //player.Current = player.CurrentPower -= attackVal    

/* From Kenn in Slack protected ArrayList insult = new ArrayList { "buck-o", "wimp", "window licker", "noob", "nerd cakes", "buster" };
protected Random rnd = new Random();
public string Name { get; set; }
public int PowerLevel { get; set; }

//create an insult method with a few insults
public virtual void Insult()
{   
    int r = rnd.Next(insult.Count);
    */

    Console.WriteLine("You're on the wrong side of the forest {0}", insult[r]);

            /* From Kenn in Slack
             * class Enemy
    {
        protected ArrayList insult = new ArrayList { "buck-o", "wimp", "window licker", "noob", "nerd cakes", "buster" };
        protected Random rnd = new Random();
        public string Name { get; set; }
        public int PowerLevel { get; set; }

        //create an insult method with a few insults
        public virtual void Insult()
        {   
            int r = rnd.Next(insult.Count);

            Console.WriteLine("You're on the wrong side of the forest {0}", insult[r]);
        }
    }

}
}



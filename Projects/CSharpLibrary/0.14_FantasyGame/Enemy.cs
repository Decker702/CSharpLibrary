using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    class Enemy
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
        public virtual void Insult()
        {
          
            ArrayList insult = new ArrayList { "buck-o", "wimp", "window licker", "noob", "nerd cakes", "buster" };
            // to add to an ArrayList use -  insult.Add ("four-eyes");
            //Arrays can not expand in size, an array list can.  Dynamically add things.  Depends on memory, which to use.
            Random rnd = new Random();
            int r = rnd.Next(insult.Count);

Console.WriteLine("You are on the wrong side of the forest {0}", insult[r]);
        }


    }
    
}

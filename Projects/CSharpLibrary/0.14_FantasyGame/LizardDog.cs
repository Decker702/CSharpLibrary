﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a new subclass of enemy (can be any name) that inherits from the enemy class
//Has a constructor and one method
namespace _0._14_FantasyGame
{
    class LizardDog : Enemy
        //LizardDog will now inhert from the Enemy Class
    {
        public LizardDog()
        {
            this.PowerLevel = 40;
            this.Name = "Lizard Dog";
        }
        //protected allows the parent method to be over ridden, need to change in enemy
        // Enemy class
        //this overrides & need virtual in parent/class to allow it to happen.
        public override void Insult()
        {
            int r = rnd.Next(insult.Count);


            Console.WriteLine("I am {0} you {1}", this.Name, insult[r]);
        }


    }
}

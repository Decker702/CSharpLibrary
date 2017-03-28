using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    //Reference enums in our class, player can be a different character types
    public enum CharacterType
    {
        Assassin = 0, 
        BlitzenBlopper = 1,
        Professor = 2,
        HorseMange = 3,
        TaxMan = 4,
        Human = 5,

    }
    //classes are templates or blue prints.
    class Player
    {
        public string PlayerName { get; set; }
        public string Clan { get; set; }
        public int CurrentPower { get; set; }
        public CharacterType Type { get; set; } 
            //instead of typing in type name, you can assign number & they select number.
        //the following is an object of the player class, calling the constructor

        public Player(string name, string clanName, CharacterType type = CharacterType.HorseMange)
            //if they don't select a type it defaults to HorseMange
        {
            this.PlayerName = name;
            this.Clan = clanName;
            this.CurrentPower = 100; //default is 100%, not set above by playerp
            this.Type = type;
        }
        public CharacterType ChooseType(int t)
        {
            switch (t)
            {
                case 0:
                    return this.Type = CharacterType.Assassin;
                case 1:
                    Console.WriteLine("You are a Blizen Blooper");
                    return this.Type = CharacterType.BlitzenBlopper;
                case 2:
                    Console.WriteLine("You are a Professor");
                    return this.Type = CharacterType.Professor;
                case 3:
                    Console.WriteLine("You are a Horse Mange");
                    return this.Type = CharacterType.HorseMange;

                case 4:
                    Console.WriteLine("You are a Tax Man");
                    return this.Type = CharacterType.TaxMan;

                case 5:
                    Console.WriteLine("You are a Human");
                    return this.Type = CharacterType.Human;

                default:
                    return this.Type = CharacterType.HorseMange;
            }
        }
        //TODO: Allows you to create a list.  Pulls up on the top bar - View, Task List
        //make a method that you can call on a player object that prints the player's power
        public void PowerLevelCheck()
        {
            Console.WriteLine("{0}'s power level is at {1}", this.PlayerName, this.CurrentPower);
        }
        //make a method for your player object for your battle cry
       
        public void BattleCry()
        {
            Console.WriteLine("YEYEYEYEEYYE!!!");

        }
        //create an override method of ToString that prints out your players details.
        //override allows you to ignore what is in C# (parent class) and allow you to use your method instead
        public override string ToString()
        {
            // the $ reads the string and looks for basic items baked in C# 
            return $"Player Name: { this.PlayerName}\n Gamer Name: { this.Clan}\n Player Type: { this.Type}";
        }
    }
}

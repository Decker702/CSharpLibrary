﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
{
    class Brain
{
    public static void Counting()
    {
        for (int i = 0; i < 201; i += 10)
        {
            if (i % 3 == 0)
            {
                SpeechSynthesizer talk = new SpeechSynthesizer();
                string toStr = i.ToString();
                Console.WriteLine(i);
                talk.Speak(toStr + " is divisable by 3");
            }
            else
            {
                Console.WriteLine(i);
            }

        }
    }
    */

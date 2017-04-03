using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace _0._04_Objects_Assembly_References
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer speak = new SpeechSynthesizer();

            //need to add System.Speech.Synthesis; to get it to work.
            //Use References to get it added.  
            //See it in the Using section at top.
        }
    }
}

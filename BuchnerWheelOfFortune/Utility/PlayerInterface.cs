using BuchnerWheelOfFortune.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuchnerWheelOfFortune.Utility
{
    public class PlayerInterface : IPlayerInterface
    {
        public string Ask(string message)
        {
            Console.WriteLine(message);
            
            return  Console.ReadLine();
        }

        public void Tell(string message)
        {
            Console.WriteLine(message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BuchnerWheelOfFortune.Interfaces
{
    public interface IPlayerInterface
    {
        string Ask(string message);
        void Tell(string message);
    }
}

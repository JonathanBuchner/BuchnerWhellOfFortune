using System;
using System.Collections.Generic;
using System.Text;

namespace BuchnerWheelOfFortune.Utility
{
    public class WFConstants
    {
        //Settings
        public const int PlayerLimit = 10;
        public const int MinumumPlayerNameLength = 2;
        public const int MaximumPlayerNameLength = 16;
        public const int StartingAmount = 0;
        //
        public const string HowManyPlayers = "How many Players?";
        public const string WhatIsPlayerName = "What is the name for Player ";
        public const string IncorrectsPlayerAmount = "Please enter a number between 1 and 10.";
        public const string PlayerNameRestrictions = "Incorrect length of player name.";
        public const string FailureToStartGame = "Failure to start game.  Please contact the game creator.";
    }
}

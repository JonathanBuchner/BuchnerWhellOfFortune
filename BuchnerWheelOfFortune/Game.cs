using BuchnerWheelOfFortune.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BuchnerWheelOfFortune
{
    /*
     * Should handle running the game
     */
    public class Game
    {
        public Game() { }
        
        public void Run()
        {
            try
            {
                var players = new GetPlayers()
                    .GetPlayerAmount()
                    .GetPlayerList()
                    .GetListOfPlayers();
            }
            catch(Exception e)
            {
                Logger.LogMessage(WFConstants.FailureToStartGame, e);
            }
            
        }
    }
}

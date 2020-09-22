using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata;
using System.Text;
using BuchnerWheelOfFortune.Interfaces;
using BuchnerWheelOfFortune.Models;
using BuchnerWheelOfFortune.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace BuchnerWheelOfFortune
{
    /*
     * Should handle setting up the game.
     */
    public class GetPlayers
    {
        private int _players;
        private List<Player> _playerList { get; set; }
        private IPlayerInterface pi;

        public GetPlayers() { pi = new PlayerInterface(); }

        public GetPlayers(IPlayerInterface playerInterface) { pi = playerInterface; }

        /*
         * Get amount of players from user 
         */
        public GetPlayers GetPlayerAmount()
        {
            var response = pi.Ask(WFConstants.HowManyPlayers);

            try
            {
                int amount = Int32.Parse(response);
                if (amount < 1) throw new ArgumentOutOfRangeException("Fewer than one player selected by user.");
                if (amount >= WFConstants.PlayerLimit) throw new ArgumentOutOfRangeException("Player number was above the provide limit.");

                _players = amount;
            }
            catch(Exception e) 
            {
                pi.Tell(WFConstants.IncorrectsPlayerAmount);
                GetPlayerAmount();
            }

            return this;
        }

        public GetPlayers GetPlayerList()
        {
            if (_players < 1) throw new ArgumentOutOfRangeException();
            
            for(var i = 1; i <= _players; i++)
            {
                _playerList.Add(AskForPlayerName(i));
            }

            return this;
        }

        private Player AskForPlayerName(int number)
        {
            var response = pi.Ask(WFConstants.WhatIsPlayerName);

            try
            {
                if (response.Length > WFConstants.MaximumPlayerNameLength) throw new ArgumentOutOfRangeException();
                if (response.Length <= WFConstants.MinumumPlayerNameLength) throw new ArgumentOutOfRangeException();
            }
            catch
            {
                Console.WriteLine(WFConstants.PlayerNameRestrictions);

                return AskForPlayerName(number);
            }

            return new Player
            {
                Name = response,
                Number = number,
                Score = WFConstants.StartingAmount
            };
        }
    }
}

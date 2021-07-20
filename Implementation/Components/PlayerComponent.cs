using Equisoft.Test.RockPaperScissors.Implementation.Components;
using Equisoft.Test.RockPaperScissors.Implementation.Constantes;
using Equisoft.Test.RockPaperScissors.Implementation.Entities;
using Equisoft.Test.RockPaperScissors.Implementation.Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Implementation.Components
{
    public class PlayerComponent : IPlayerComponent
    {
        private readonly IConsoleHelper _helper;

        public const string FirstPlayer = "first player";
        public const string SecondPlayer = "second player";

        public PlayerComponent(IConsoleHelper helper)
        {
            _helper = helper;
        }

        public Dictionary<Player, int> ChooseThePlayer(string option)
        {
            var players = new Dictionary<Player, int>();

            

            if (option == "1")
            {
                _helper.PlayerNamePanel(FirstPlayer);
                players.Add(new Player { Name = Console.ReadLine() }, 0);

                _helper.PlayerNamePanel(SecondPlayer);
                players.Add(new Player { Name = Console.ReadLine() }, 0);
            }

            if (option == "2")
            {
                _helper.PlayerNamePanel(FirstPlayer);
                players.Add(new Player { Name = Console.ReadLine() }, 0);
                players.Add(new Player { Name = Constants.Computer }, 0);
            }

            return players;
        }

        public string GetFirstPlayerChoice(Dictionary<Player, int> players)
        {
            return _helper.RockPaperScissorsPanel(players.First().Key);
        }
        public string GetSecondPlayerChoice(Dictionary<Player, int> players)
        {
            if (players.Last().Key.Name != Constants.Computer)
            {
                return _helper.RockPaperScissorsPanel(players.Last().Key);
            }
            else
            {
                Random randomChoice = new Random();
                return randomChoice.Next(1, 4).ToString();
            }
        }
    }
}
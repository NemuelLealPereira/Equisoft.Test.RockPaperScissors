using Equisoft.Test.RockPaperScissors.Implementation.Constantes;
using Equisoft.Test.RockPaperScissors.Implementation.Entities;
using Equisoft.Test.RockPaperScissors.Implementation.Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Equisoft.Test.RockPaperScissors.Implementation.Components
{
    public class GameComponent : IGameComponent
    {
        private readonly IPlayerComponent _playerComponent;
        private readonly IRuleComponent _ruleComponent;
        private readonly IConsoleHelper _helper;

        public GameComponent(IPlayerComponent playerComponent, IRuleComponent ruleComponent, IConsoleHelper helper)
        {
            _playerComponent = playerComponent;
            _ruleComponent = ruleComponent;
            _helper = helper;
        }

        public Dictionary<Player, int> InitGame()
        {
            _helper.WelcomeMultiplayerPanel();

            return _playerComponent.ChooseThePlayer(Console.ReadLine());
        }

        public void ReadyGo(Dictionary<Player, int> players)
        {
            do
            {
                string firstPlayerChoice = _playerComponent.GetFirstPlayerChoice(players);               
                string secondPlayerChoice = _playerComponent.GetSecondPlayerChoice(players);

                _helper.SectionSeparator();

                switch (firstPlayerChoice)
                {
                    case Constants.Rock:
                        _ruleComponent.RockRules(firstPlayerChoice, secondPlayerChoice, players);                        
                        break;

                    case Constants.Paper:
                        _ruleComponent.PaperRules(firstPlayerChoice, secondPlayerChoice, players);                        
                        break;

                    case Constants.Scissors:
                        _ruleComponent.ScissorsRules(firstPlayerChoice, secondPlayerChoice, players);                        
                        break;
                }

                
                Console.WriteLine($"{players.First().Key.Name} has {players.First().Value} points - {players.Last().Key.Name} has {players.Last().Value} points");

                _helper.SectionSeparator();


            } while (players.First().Value < 3 && players.Last().Value < 3);
        }

        public void CelebrateWinner(Dictionary<Player, int> players)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");

            if (players.First().Value == 3)
                _helper.Congratulations(players.First().Key);
            else
                _helper.Congratulations(players.Last().Key);

            _helper.WinnerPainel();
            
            Console.ReadKey();
        }
    }
}

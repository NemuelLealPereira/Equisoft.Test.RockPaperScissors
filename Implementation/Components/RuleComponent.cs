using System;
using System.Collections.Generic;
using System.Linq;
using Equisoft.Test.RockPaperScissors.Implementation.Entities;

namespace Equisoft.Test.RockPaperScissors.Implementation.Components
{
    public class RuleComponent : IRuleComponent
    {
        public void RockRules(string firstPlayerChoice, string secondPlayerChoice, Dictionary<Player, int> players)
        {
            if (secondPlayerChoice == "1")
            {
                Console.WriteLine($"{players.First().Key.Name} chose Rock");
                Console.WriteLine($"{players.Last().Key.Name} chose Rock");
                Console.WriteLine("There was no winner.");
            }

            else if (secondPlayerChoice == "2")
            {
                Console.WriteLine($"{players.First().Key.Name} chose Rock");
                Console.WriteLine($"{players.Last().Key.Name} chose Paper");
                Console.WriteLine($"{players.Last().Key.Name} wins");
                players[players.Last().Key]++;
            }
            else if (secondPlayerChoice == "3")
            {
                Console.WriteLine($"{players.First().Key.Name} chose Rock");
                Console.WriteLine($"{players.Last().Key.Name} chose Scissors");
                Console.WriteLine($"{players.First().Key.Name} wins");
                players[players.First().Key]++;
            }
        }

        public void PaperRules(string firstPlayerChoice, string secondPlayerChoice, Dictionary<Player, int> players)
        {
            if (secondPlayerChoice == "1")
            {

                Console.WriteLine($"{players.First().Key.Name} chose Paper");
                Console.WriteLine($"{players.Last().Key.Name} chose Rock");
                Console.WriteLine($"{players.First().Key.Name} wins");
                players[players.First().Key]++;
            }

            else if (secondPlayerChoice == "2")
            {
                Console.WriteLine($"{players.First().Key.Name} chose Paper");
                Console.WriteLine($"{players.Last().Key.Name} chose Paper");
                Console.WriteLine("There was no winner.");
            }
            else if (secondPlayerChoice == "3")
            {
                Console.WriteLine($"{players.First().Key.Name} chose Paper");
                Console.WriteLine($"{players.Last().Key.Name} chose Scissors");
                players[players.Last().Key]++;
            }
        }

        public void ScissorsRules(string firstPlayerChoice, string secondPlayerChoice, Dictionary<Player, int> players)
        {
            if (secondPlayerChoice == "1")
            {

                //this is a tie
                Console.WriteLine($"{players.First().Key.Name} chose Scissors");
                Console.WriteLine($"{players.Last().Key.Name} chose Rock");
                Console.WriteLine($"{players.Last().Key.Name} wins.");
                players[players.Last().Key]++;
            }

            else if (secondPlayerChoice == "2")
            {
                Console.WriteLine($"{players.First().Key.Name} chose Scissors");
                Console.WriteLine($"{players.Last().Key.Name} chose Paper");
                Console.WriteLine($"{players.First().Key.Name} wins");
                players[players.First().Key]++;
            }
            else if (secondPlayerChoice == "3")
            {
                Console.WriteLine($"{players.First().Key.Name} chose Scissors");
                Console.WriteLine($"{players.Last().Key.Name} chose Scissors");
                Console.WriteLine("There was no winner");
            }
        }
    }
}
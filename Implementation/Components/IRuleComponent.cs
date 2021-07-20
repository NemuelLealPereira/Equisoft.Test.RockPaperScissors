using System.Collections.Generic;
using Equisoft.Test.RockPaperScissors.Implementation.Entities;

namespace Equisoft.Test.RockPaperScissors.Implementation.Components
{
    public interface IRuleComponent
    {
        void RockRules(string firstPlayerChoice, string secondPlayerChoice, Dictionary<Player, int> players);
        void PaperRules(string firstPlayerChoice, string secondPlayerChoice, Dictionary<Player, int> players);
        void ScissorsRules(string firstPlayerChoice, string secondPlayerChoice, Dictionary<Player, int> players);
    }
}
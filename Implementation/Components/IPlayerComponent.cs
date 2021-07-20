using Equisoft.Test.RockPaperScissors.Implementation.Entities;
using System.Collections.Generic;

namespace Equisoft.Test.RockPaperScissors.Implementation.Components
{
    public interface IPlayerComponent
    {
        Dictionary<Player, int> ChooseThePlayer(string option);
        string GetFirstPlayerChoice(Dictionary<Player, int> players);
        string GetSecondPlayerChoice(Dictionary<Player, int> players);
    }
}
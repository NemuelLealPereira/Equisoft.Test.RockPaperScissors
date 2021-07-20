using Equisoft.Test.RockPaperScissors.Implementation.Entities;
using System.Collections.Generic;

namespace Equisoft.Test.RockPaperScissors.Implementation.Components
{
    public interface IGameComponent
    {
        Dictionary<Player, int> InitGame();
        void ReadyGo(Dictionary<Player, int> players);
        void CelebrateWinner(Dictionary<Player, int> players);
    }
}
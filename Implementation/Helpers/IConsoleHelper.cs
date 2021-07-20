using System.Collections.Generic;
using Equisoft.Test.RockPaperScissors.Implementation.Entities;

namespace Equisoft.Test.RockPaperScissors.Implementation.Helper
{
    public interface IConsoleHelper
    {
        void MultiplayerPanel();
        void SectionSeparator();
        void WinnerPainel();
        public string RockPaperScissorsPanel(Player player);
        void PlayerNamePanel(string phrasePlayerNamePanel);
    }
}

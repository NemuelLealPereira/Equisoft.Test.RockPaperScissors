using System;
using Equisoft.Test.RockPaperScissors.Implementation.Constantes;
using Equisoft.Test.RockPaperScissors.Implementation.Entities;

namespace Equisoft.Test.RockPaperScissors.Implementation.Helper
{
    public class ConsoleHelper : IConsoleHelper
    {
        public void MultiplayerPanel()
        {
            Console.WriteLine("");
            Console.WriteLine("1. Human vs Human");
            Console.WriteLine("2. Human vs Computer");
            Console.WriteLine("");
        }        

        

        public void SectionSeparator()
        {
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
        }

        public void WinnerPainel()
        {
            Console.WriteLine("");
            Console.WriteLine(" ÛÛÛÛÛ ÛÛÛÛÛ                        ÛÛÛÛÛ   ÛÛÛ   ÛÛÛÛÛ                     ÛÛÛ ÛÛÛ     ");
            Console.WriteLine("°°ÛÛÛ °°ÛÛÛ                        °°ÛÛÛ   °ÛÛÛ  °°ÛÛÛ                     °ÛÛÛ°ÛÛÛ     ");
            Console.WriteLine(" °°ÛÛÛ ÛÛÛ    ÛÛÛÛÛÛ  ÛÛÛÛÛ ÛÛÛÛ    °ÛÛÛ   °ÛÛÛ   °ÛÛÛ   ÛÛÛÛÛÛ  ÛÛÛÛÛÛÛÛ  °ÛÛÛ°ÛÛÛ     ");
            Console.WriteLine("  °°ÛÛÛÛÛ    ÛÛÛ°°ÛÛÛ°°ÛÛÛ °ÛÛÛ     °ÛÛÛ   °ÛÛÛ   °ÛÛÛ  ÛÛÛ°°ÛÛÛ°°ÛÛÛ°°ÛÛÛ °ÛÛÛ°ÛÛÛ     ");
            Console.WriteLine("   °°ÛÛÛ    °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ     °°ÛÛÛ  ÛÛÛÛÛ  ÛÛÛ  °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ°ÛÛÛ     ");
            Console.WriteLine("    °ÛÛÛ    °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ      °°°ÛÛÛÛÛ°ÛÛÛÛÛ°   °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ °°° °°°      ");
            Console.WriteLine("    ÛÛÛÛÛ   °°ÛÛÛÛÛÛ  °°ÛÛÛÛÛÛÛÛ       °°ÛÛÛ °°ÛÛÛ     °°ÛÛÛÛÛÛ  ÛÛÛÛ ÛÛÛÛÛ ÛÛÛ ÛÛÛ     ");
            Console.WriteLine("    °°°°°     °°°°°°    °°°°°°°°         °°°   °°°       °°°°°°  °°°° °°°°° °°° °°°     ");
            Console.WriteLine("");
            Console.ResetColor();
        }
        
        public string RockPaperScissorsPanel(Player player)
        {
            Console.WriteLine($"Please enter a number below for {player.Name} choice and press enter:");

            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");

            return Console.ReadLine();
        }

        public void PlayerNamePanel(string phrasePlayerNamePanel)
        {
            Console.WriteLine($"{Constants.PlayerName} {phrasePlayerNamePanel}"); 
        }
    }
}

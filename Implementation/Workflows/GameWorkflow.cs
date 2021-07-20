using Equisoft.Test.RockPaperScissors.Implementation.Components;

namespace Equisoft.Test.RockPaperScissors.Implementation.Workflows
{
    public class GameWorkflow : IGameWorkflow
    {
        private readonly IGameComponent _gameComponent;

        public GameWorkflow(IGameComponent gameComponent)
        {
            _gameComponent = gameComponent;
        }

        public void RunRockPaperScissors()
        {
            var players = _gameComponent.InitGame();

            _gameComponent.ReadyGo(players);

            _gameComponent.CelebrateWinner(players);
        }
    }
}
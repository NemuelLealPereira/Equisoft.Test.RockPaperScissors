using Equisoft.Test.RockPaperScissors.Implementation.Components;
using Equisoft.Test.RockPaperScissors.Implementation.Entities;
using Equisoft.Test.RockPaperScissors.Implementation.Workflows;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Implementation.Test
{
    [ExcludeFromCodeCoverage]
    public class GameWorkflowTest : IDisposable
    {

        private readonly Mock<IGameComponent> _mockGameComponent;
        private readonly GameWorkflow _GameWorkflow;

        public GameWorkflowTest()
        {
            _mockGameComponent = new Mock<IGameComponent>(MockBehavior.Strict);

            _GameWorkflow = new GameWorkflow(_mockGameComponent.Object);
        }

        [Fact]
        public void GameWorkflow_WhenCallInitGame_ThrowsException()
        {
            //Arrange
            _mockGameComponent.Setup(m => m.InitGame()).Throws(new Exception());

            //Act
            Assert.Throws<Exception>(() => _GameWorkflow.RunRockPaperScissors());

            //Assert
            _mockGameComponent.Verify(m => m.InitGame(), Times.Once);
        }

        [Fact]
        public void GameWorkflow_WhenCallReadyGo_ThrowsException()
        {
            //Arrange
            var players = new Dictionary<Player, int>();

            _mockGameComponent.Setup(m => m.InitGame()).Returns(players);
            _mockGameComponent.Setup(m => m.ReadyGo(players)).Throws(new Exception());

            //Act
            Assert.Throws<Exception>(() => _GameWorkflow.RunRockPaperScissors());

            //Assert
            _mockGameComponent.Verify(m => m.InitGame(), Times.Once);
            _mockGameComponent.Verify(m => m.ReadyGo(players), Times.Once);
        }

        [Fact]
        public void GameWorkflow_WhenCallCelebrateWinner_ThrowsException()
        {
            //Arrange
            var players = new Dictionary<Player, int>();

            _mockGameComponent.Setup(m => m.InitGame()).Returns(players);
            _mockGameComponent.Setup(m => m.ReadyGo(players));
            _mockGameComponent.Setup(m => m.CelebrateWinner(players)).Throws(new Exception());

            //Act
            Assert.Throws<Exception>(() => _GameWorkflow.RunRockPaperScissors());

            //Assert
            _mockGameComponent.Verify(m => m.InitGame(), Times.Once);
            _mockGameComponent.Verify(m => m.ReadyGo(players), Times.Once);
            _mockGameComponent.Verify(m => m.CelebrateWinner(players), Times.Once);
        }

        [Fact]
        public void GameWorkflow_WhenCallAllMethods_Success()
        {
            //Arrange
            var players = new Dictionary<Player, int>();

            _mockGameComponent.Setup(m => m.InitGame()).Returns(players);
            _mockGameComponent.Setup(m => m.ReadyGo(players));
            _mockGameComponent.Setup(m => m.CelebrateWinner(players));

            //Act
            _GameWorkflow.RunRockPaperScissors();

            //Assert
            _mockGameComponent.Verify(m => m.InitGame(), Times.Once);
            _mockGameComponent.Verify(m => m.ReadyGo(players), Times.Once);
            _mockGameComponent.Verify(m => m.CelebrateWinner(players), Times.Once);
        }

        public void Dispose()
        {
            _mockGameComponent.VerifyAll();
        }
    }
}
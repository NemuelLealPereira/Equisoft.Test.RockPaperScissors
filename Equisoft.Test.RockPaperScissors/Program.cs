using Equisoft.Test.RockPaperScissors.Implementation.DependencyInjection;
using Equisoft.Test.RockPaperScissors.Implementation.Workflows;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        ServiceProvider serviceProvider = Inicializer();

        var gameWorkflow = serviceProvider.GetService<IGameWorkflow>();

        gameWorkflow.RunRockPaperScissors();
    }

    private static ServiceProvider Inicializer()
    {
        return new ServiceCollection()
            .AddRockPaperScissorsDependenciesInjection()
            .BuildServiceProvider();
    }
}
using Equisoft.Test.RockPaperScissors.Implementation.Components;
using Equisoft.Test.RockPaperScissors.Implementation.Helper;
using Equisoft.Test.RockPaperScissors.Implementation.Workflows;
using Implementation.Components;
using Microsoft.Extensions.DependencyInjection;

namespace Equisoft.Test.RockPaperScissors.Implementation.DependencyInjection
{
    public static class RegisterDependencies
    {
        public static IServiceCollection AddRockPaperScissorsDependenciesInjection(this IServiceCollection services)
        {
            //Workflows
            services.AddTransient<IGameWorkflow, GameWorkflow>();

            //Components
            services.AddTransient<IPlayerComponent, PlayerComponent>();
            services.AddTransient<IGameComponent, GameComponent>();
            services.AddTransient<IRuleComponent, RuleComponent>();

            //Helpers
            services.AddTransient<IConsoleHelper, ConsoleHelper>();
            
            return services;
        }
    }
}

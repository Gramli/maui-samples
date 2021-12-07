using RockPaperScissors.Patterns.Mediator;

namespace RockPaperScissors.ViewModels.Factories
{
    internal class PlayerViewModelFactory : IPlayerViewModelFactory
    {
        public PlayerViewModel CreatePlayerViewModel(IMediator mediator)
        {
            return new PlayerViewModel(mediator);
        }
    }
}

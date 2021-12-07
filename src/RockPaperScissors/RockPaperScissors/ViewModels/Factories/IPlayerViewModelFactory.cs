using RockPaperScissors.Patterns.Mediator;

namespace RockPaperScissors.ViewModels.Factories
{
    public interface IPlayerViewModelFactory
    {
        PlayerViewModel CreatePlayerViewModel(IMediator mediator);
    }
}

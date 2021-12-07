using RockPaperScissors.Patterns.Mediator;

namespace RockPaperScissors.ViewModels.Factories
{
    public interface IPlayGroundViewModelFactory
    {
        PlayGroundViewModel CreatePlayGroundViewModel(IMediator mediator);
    }
}

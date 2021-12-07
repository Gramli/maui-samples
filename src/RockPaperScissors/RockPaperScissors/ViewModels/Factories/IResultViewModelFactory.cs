using RockPaperScissors.Patterns.Mediator;

namespace RockPaperScissors.ViewModels.Factories
{
    public interface IResultViewModelFactory
    {
        ResultViewModel CreateResultViewModel(IMediator mediator);
    }
}

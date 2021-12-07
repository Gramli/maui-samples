using RockPaperScissors.Patterns.Mediator;

namespace RockPaperScissors.ViewModels.Factories
{
    internal class ResultViewModelFactory : IResultViewModelFactory
    {
        public ResultViewModel CreateResultViewModel(IMediator mediator)
        {
            return new ResultViewModel(mediator);
        }
    }
}

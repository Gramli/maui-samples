using RockPaperScissors.Converters;
using RockPaperScissors.Models;
using RockPaperScissors.Patterns.Mediator;

namespace RockPaperScissors.ViewModels.Factories
{
    internal class PlayGroundViewModelFactory : IPlayGroundViewModelFactory
    {
        private readonly IPlayGround _playGround;
        private readonly IGameItemToImageSource _gameItemToImageSource;

        public PlayGroundViewModelFactory(IPlayGround playGround, IGameItemToImageSource gameItemToImageSource)
        {
            _playGround = playGround;
            _gameItemToImageSource = gameItemToImageSource;
        }
        public PlayGroundViewModel CreatePlayGroundViewModel(IMediator mediator)
        {
            return new PlayGroundViewModel(mediator, _playGround, _gameItemToImageSource);
        }
    }
}

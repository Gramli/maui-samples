using Microsoft.Maui.Controls;
using RockPaperScissors.Converters;
using RockPaperScissors.Models;
using RockPaperScissors.Patterns.Mediator;
using System;
using System.ComponentModel;
using System.Timers;

namespace RockPaperScissors.ViewModels
{
    public record GameResultMessage(IGameResult GameResult) : IMessageObject;
    public class PlayGroundViewModel : BaseParticipantViewModel, IGameReset, INotifyPropertyChanged
    {
        private ImageSource _playerImage;
        public ImageSource PlayerImage
        {
            get { return _playerImage; }
            set 
            { 
                _playerImage = value;
                NotifyPropertyChanged(nameof(PlayerImage));
            }
        }
        private ImageSource _middleImage;
        public ImageSource MiddleImage
        {
            get { return _middleImage; }
            set
            {
                _middleImage = value;
                NotifyPropertyChanged(nameof(MiddleImage));
            }
        }
        private ImageSource _enemyImage;
        public ImageSource EnemyImage
        {
            get { return _enemyImage; }
            set
            {
                _enemyImage = value;
                NotifyPropertyChanged(nameof(EnemyImage));
            }
        }

        private IGameResult _gameResult;
        private readonly IPlayGround _playGround;
        private readonly IGameItemToImageSource _gameItemToImageSource;
        private readonly System.Timers.Timer _timer;
        private int _count = 0;

        public PlayGroundViewModel(IMediator mediator, IPlayGround playGround, IGameItemToImageSource gameItemToImageSource) 
            : base(mediator)
        {
            _playGround = playGround;
            _gameItemToImageSource = gameItemToImageSource;
            _playGround.OnResult += _playGround_OnResult;

            _timer = new Timer
            {
                Interval = 500
            };
            _timer.Elapsed += Timer_Elapsed;
        }

        private void _playGround_OnResult(object sender, IGameResult e)
        {
            _gameResult = e;
            _timer.Start();
        }

        public override void Notify(IMessageObject message)
        {
            switch(message)
            {
                case PlayerMove playerMove:
                    _playGround.GenerateRandomEnemySelection();
                    _playGround.SetPlayerSelection(playerMove.PlayerSelection);
                    PlayerImage = _gameItemToImageSource.Convert(_gameResult.Player);
                    break;
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            switch (_count)
            {
                case 0:
                    MiddleImage = "icons8_keycap_digit_one_100px.png";
                    break;
                case 1:
                    MiddleImage = "icons8_keycap_digit_two_100px.png";
                    break;
                case 2:
                    MiddleImage = "icons8_keycap_digit_three_100px.png";
                    break;
                case 3:
                    _timer.Stop();

                    PlayerImage = _gameItemToImageSource.Convert(_gameResult.Player);
                    EnemyImage = _gameItemToImageSource.Convert(_gameResult.Enemy);
                    MiddleImage = (_gameResult.Winner == Winner.Player) || (_gameResult.Winner == Winner.Tie) ?
                        "icons8_good_quality_100px.png" :
                        "icons8_unlike_100px.png";
                    _mediator.Send<PlayGroundViewModel>(new GameResultMessage(_gameResult));
                    break;
            }
            _count++;
        }

        public void Reset()
        {
            _gameResult = null;
            _count = 0;
            MiddleImage = null;
            EnemyImage = null;
            PlayerImage = null;
        }

        public void ResetActualGame()
        {
            Reset();
        }
    }
}

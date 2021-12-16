using Microsoft.Maui.Controls;
using RockPaperScissors.Models;
using RockPaperScissors.Patterns.Mediator;
using System;

namespace RockPaperScissors.ViewModels
{
    public record class PlayerMove (GameItem PlayerSelection) : IMessageObject;
    public class PlayerViewModel : BaseParticipantViewModel, IGameReset
    {
        private bool _isEnabled = true;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set 
            { 
                _isEnabled = value; 
                NotifyPropertyChanged(nameof(IsEnabled));
            }
        }

        public Command<GameItem> PlayerSelectionClickCmd { get; }

        public PlayerViewModel(IMediator mediator) 
            : base(mediator)
        {
            PlayerSelectionClickCmd = new Command<GameItem>(PlayerSelectionClick);
        }

        public override void Notify(IMessageObject message)
        {
            throw new NotImplementedException();
        }

        private void PlayerSelectionClick(GameItem item)
        {
            IsEnabled = false;
            _mediator.Send<PlayerViewModel>(new PlayerMove(item));
        }

        public void Reset()
        {
            IsEnabled = true;
        }

        public void ResetActualGame()
        {
            Reset();
        }
    }
}

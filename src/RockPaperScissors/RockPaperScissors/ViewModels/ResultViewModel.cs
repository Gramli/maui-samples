using RockPaperScissors.Models;
using RockPaperScissors.Patterns.Mediator;
using System;

namespace RockPaperScissors.ViewModels
{
    public class ResultViewModel : BaseParticipantViewModel, IGameReset
    {
        private int _wins;
        public int Wins
        {
            get { return _wins; }
            set 
            { 
                _wins = value; 
                NotifyPropertyChanged(nameof(Wins));
            }
        }
        private int _losses;
        public int Losses
        {
            get { return _losses; }
            set
            {
                _losses = value;
                NotifyPropertyChanged(nameof(Losses));
            }
        }
        private int _ties;
        public int Ties
        {
            get { return _ties; }
            set
            {
                _ties = value;
                NotifyPropertyChanged(nameof(Ties));
            }
        }
        public ResultViewModel(IMediator mediator) 
            : base(mediator)
        {
        }

        public override void Notify(IMessageObject message)
        {
            var result = message as GameResultMessage ?? throw new ArgumentException(nameof(message));
            switch (result.GameResult.Winner)
            {
                case Winner.Enemy:
                    Losses++;
                    break;
                case Winner.Player:
                    Wins++;
                    break;
                case Winner.Tie:
                    Ties++;
                    break;
            }
        }

        public void Reset()
        {
            
        }
    }
}

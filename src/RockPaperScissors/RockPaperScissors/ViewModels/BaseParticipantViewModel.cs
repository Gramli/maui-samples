using RockPaperScissors.Patterns.Mediator;
using System.ComponentModel;

namespace RockPaperScissors.ViewModels
{
    public abstract class BaseParticipantViewModel : Participant, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected BaseParticipantViewModel(IMediator mediator) 
            : base(mediator)
        {
        }

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

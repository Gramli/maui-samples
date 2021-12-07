using Microsoft.Maui.Controls;
using RockPaperScissors.Patterns.Mediator;
using RockPaperScissors.ViewModels.Factories;
using System;
using System.ComponentModel;

namespace RockPaperScissors.ViewModels
{
    public class MainPageViewModel : IMediator, INotifyPropertyChanged
    {
        private readonly ResultViewModel _resultViewModel;
        public ResultViewModel ResultViewModel { get { return _resultViewModel; } }

        private readonly PlayGroundViewModel _playGroundViewModel;
        public PlayGroundViewModel PlayGroundViewModel { get { return _playGroundViewModel; } }

        private readonly PlayerViewModel _playerViewModel;
        public PlayerViewModel PlayerViewModel { get { return _playerViewModel; } }

        public event PropertyChangedEventHandler PropertyChanged;

        private bool _allowReset;
        public bool AllowReset
        {
            get { return _allowReset; }
            private set
            {
                _allowReset = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(AllowReset)));
            }
        }

        public Command ResetCmd { get; private set; }
        public MainPageViewModel(IResultViewModelFactory resultViewModelFactory, 
            IPlayGroundViewModelFactory playGroundViewModelFactory, 
            IPlayerViewModelFactory playerViewModelFactory)
        {
            _resultViewModel = resultViewModelFactory.CreateResultViewModel(this);
            _playGroundViewModel = playGroundViewModelFactory.CreatePlayGroundViewModel(this);
            _playerViewModel = playerViewModelFactory.CreatePlayerViewModel(this);
            ResetCmd = new Command(Reset);
        }

        public void Send<T>(IMessageObject sendingObject) where T : IParticipant
        {
            switch(typeof(T))
            {
                case Type playerType when playerType == typeof(PlayerViewModel):
                    _playGroundViewModel.Notify(sendingObject);
                    break;
                case Type playGroundType when playGroundType == typeof(PlayGroundViewModel):
                    AllowReset = true;
                    _resultViewModel.Notify(sendingObject);
                    break;
            }
        }

        public void Reset()
        {
            _resultViewModel.Reset();
            _playGroundViewModel.Reset();
            _playerViewModel.Reset();
            AllowReset = false;
        }
    }
}

using RockPaperScissors.Views;
using System.ComponentModel;

namespace RockPaperScissors.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged, IGameReset
    {
        private bool _gameExists;
        public bool GameExists
        {
            get { return _gameExists; }
            private set
            {
                _gameExists = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(GameExists)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public GamePage GamePage { get; }
        public HomePageViewModel(GamePage gamePage)
        {
            GamePage = gamePage;
            gamePage.Disappearing += GamePage_Disappearing;
        }

        private void GamePage_Disappearing(object sender, System.EventArgs e)
        {
            GameExists = true;
        }

        public void ResetActualGame()
        {
            GamePage.ResetActualGame();
        }

        public void Reset()
        {
            GamePage.Reset();
        }
    }
}

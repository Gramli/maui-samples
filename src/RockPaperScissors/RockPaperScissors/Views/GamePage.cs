using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using RockPaperScissors.Extensions;
using RockPaperScissors.ViewModels;
using RockPaperScissors.Views.Game;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace RockPaperScissors.Views
{
    public class GamePage : ContentPage, IGameReset
    {
        private enum Row { First, Second, Third, Fourth }

        private readonly IGameReset _gameReset;
        public GamePage(MainPageViewModel mainPageViewModel, PlayerView playerView, PlayGroundView playGroundView, ResultView resultView)
        {
            _gameReset = mainPageViewModel;
            BindingContext = mainPageViewModel;
            Title = "Game";
            Content = new Grid
            {
                BackgroundColor = Color.FromArgb("FFCB47"),
                RowDefinitions = Rows.Define(
                    (Row.First, 50),
                    (Row.Second, 150),
                    (Row.Third, 150),
                    (Row.Fourth, 150)),
                Children = {
                    resultView.Bind(BindingContextProperty, nameof(MainPageViewModel.ResultViewModel))
                    .Row(Row.First),
                    playGroundView.Bind(BindingContextProperty, nameof(MainPageViewModel.PlayGroundViewModel))
                    .Row(Row.Second)
                    .CenterVertical(),
                    playerView.Bind(BindingContextProperty, nameof(MainPageViewModel.PlayerViewModel))
                    .CenterVertical()
                    .Row(Row.Third),
                    new ImageButton()
                    {
                        Source = "icons8_available_updates_100px.png",
                    }
                    .SetCentered100pxImageButton()
                    .Bind(Button.CommandProperty, nameof(MainPageViewModel.ResetCmd))
                    .Row(Row.Fourth)
                    .Bind(ImageButton.IsVisibleProperty,nameof(MainPageViewModel.AllowReset), BindingMode.TwoWay)
                }
            };
        }

        public void ResetActualGame()
        {
            _gameReset.ResetActualGame();
        }

        public void Reset()
        {
            _gameReset.Reset();
        }
    }
}
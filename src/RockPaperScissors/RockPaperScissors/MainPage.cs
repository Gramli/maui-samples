using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using RockPaperScissors.Extensions;
using RockPaperScissors.ViewModels;
using RockPaperScissors.Views;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace RockPaperScissors
{
    public class MainPage : ContentPage
    {
        private enum Row { First, Second, Third, Fourth }
        public MainPage(MainPageViewModel mainPageViewModel, PlayerView playerView, PlayGroundView playGroundView, ResultView resultView)
        {
            BindingContext = mainPageViewModel;
            Content = new Grid
            {
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
                    .Bind(Button.CommandProperty, nameof(MainPageViewModel.ResetCmd))
                    .Row(Row.Fourth)
                    .SetCentered100pxImageButton()
                    .Bind(ImageButton.IsVisibleProperty,nameof(MainPageViewModel.AllowReset), BindingMode.TwoWay)
                }
            };
        }
    }
}
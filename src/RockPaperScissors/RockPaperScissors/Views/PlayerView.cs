using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using RockPaperScissors.Extensions;
using RockPaperScissors.ViewModels;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace RockPaperScissors.Views
{
    public class PlayerView : ContentView
    {
        private enum Column { Rock, Paper, Scissors }
        public PlayerView()
        {
            Content = new Grid()
            {
                BackgroundColor = Color.FromArgb("1768AC"),
                ColumnDefinitions = Columns.Define(
                    (Column.Rock, Star),
                    (Column.Paper, Star),
                    (Column.Scissors, Star)),
                Children = {
                    new ImageButton()
                    {
                        Source = "icons8_rock_100px.png",
                        CommandParameter = Models.GameItem.Rock
                    }.Bind(Button.CommandProperty, nameof(PlayerViewModel.PlayerSelectionClickCmd))
                    .Bind(Button.IsEnabledProperty, nameof(PlayerViewModel.IsEnabled), BindingMode.TwoWay)
                    .Column(Column.Rock)
                    .SetCentered100pxImageButton(),
                    new ImageButton()
                    {
                        Source = "icons8_roll_of_paper_100px.png",
                        CommandParameter = Models.GameItem.Paper,
                    }.Bind(Button.CommandProperty, nameof(PlayerViewModel.PlayerSelectionClickCmd))
                    .Bind(Button.IsEnabledProperty, nameof(PlayerViewModel.IsEnabled), BindingMode.TwoWay)
                    .Column(Column.Paper)
                    .SetCentered100pxImageButton(),
                    new ImageButton()
                    {
                        Source = "icons8_scissors_100px.png",
                        CommandParameter = Models.GameItem.Scissors
                    }.Bind(Button.CommandProperty, nameof(PlayerViewModel.PlayerSelectionClickCmd))
                    .Bind(Button.IsEnabledProperty, nameof(PlayerViewModel.IsEnabled), BindingMode.TwoWay)
                    .Column(Column.Scissors)
                    .SetCentered100pxImageButton()
                }
            }.Bind(Grid.IsEnabledProperty, nameof(PlayerViewModel.IsEnabled), BindingMode.TwoWay);

        }
    }
}
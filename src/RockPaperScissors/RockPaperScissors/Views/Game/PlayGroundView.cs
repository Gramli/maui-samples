using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using RockPaperScissors.Extensions;
using RockPaperScissors.ViewModels;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace RockPaperScissors.Views.Game
{
    public class PlayGroundView : ContentView
    {
        private enum Column { Player, Middle, Enemy }
        public PlayGroundView()
        {
            Content = new Grid
            {
                BackgroundColor = Color.FromArgb("06BEE1"),
                ColumnDefinitions = Columns.Define(
                    (Column.Player, Star),
                    (Column.Middle, Star),
                    (Column.Enemy, Star)),
                Children = {
                    new Image()
                    .SetCentered100pxImage()
                    .Column(Column.Player)
                    .Bind(Image.SourceProperty, nameof(PlayGroundViewModel.PlayerImage), BindingMode.TwoWay),
                    new Image()
                    .SetCentered100pxImage()
                    .Column(Column.Middle)
                    .Bind(Image.SourceProperty, nameof(PlayGroundViewModel.MiddleImage), BindingMode.TwoWay),
                    new Image()
                    .SetCentered100pxImage()
                    .Column(Column.Enemy)
                    .Bind(Image.SourceProperty, nameof(PlayGroundViewModel.EnemyImage), BindingMode.TwoWay),
                }
            };
        }

    }
}

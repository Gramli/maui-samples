using Microsoft.Maui.Controls;
using RockPaperScissors.ViewModels;
using System;
using CommunityToolkit.Maui.Markup;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;
using Microsoft.Maui.Graphics;

namespace RockPaperScissors.Views
{
    public class ResultView : ContentView
    {
        private enum Column { Wins, Ties, Looses }
        public ResultView()
        {
            Content = new Grid
            {
                BackgroundColor = Color.FromArgb("FFCB47"),
                ColumnDefinitions = Columns.Define(
                    (Column.Wins, Star),
                    (Column.Ties, Star),
                    (Column.Looses, Star)),
                Children = {
                    new Label()
                    .Center()
                    .Bind(Label.TextProperty,nameof(ResultViewModel.Wins), BindingMode.TwoWay, stringFormat: "Wins: {0}")
                    .Column(Column.Wins),
                    new Label()
                    .Center()
                    .Bind(Label.TextProperty,nameof(ResultViewModel.Ties), BindingMode.TwoWay, stringFormat: "Ties: {0}")
                    .Column(Column.Ties),
                    new Label()
                    .Center()
                    .Bind(Label.TextProperty,nameof(ResultViewModel.Losses), BindingMode.TwoWay, stringFormat: "Looses: {0}")
                    .Column(Column.Looses),
                }
            };
        }
    }
}
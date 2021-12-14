using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using RockPaperScissors.Extensions;
using RockPaperScissors.ViewModels;
using RockPaperScissors.Views;
using System;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace RockPaperScissors.Views
{
    public class HomePage : ContentPage
    {
        public HomePage(IServiceProvider serviceProvider)
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" },
                    new Button()
                    {
                        Text = "New Game",
                        Command = new Command(() => 
                        {
                            var page = (Page)serviceProvider.GetService(typeof(GamePage));
                            Navigation.PushAsync(page);
                        }),

                    }
                }
            };
        }
    }
}
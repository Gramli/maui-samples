using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using RockPaperScissors.Extensions;
using RockPaperScissors.ViewModels;

namespace RockPaperScissors.Views
{
    public class HomePage : ContentPage
    {
        public HomePageViewModel HomePageViewModel { get { return (HomePageViewModel)BindingContext;  } }
        public HomePage(HomePageViewModel homePageViewModel)
        {
            Title = "Main Menu";
            BindingContext = homePageViewModel;
            Content = new StackLayout
            {
                        BackgroundColor = Color.FromArgb("FFCB47"),
                        Children = {
                            new Image()
                            {
                                Source = "dotnet_bot.svg",
                                MaximumHeightRequest = 500,
                                Margin = new Microsoft.Maui.Thickness(5,5,5,5)
                            },
                            new Button()
                            {
                                Text = "Continue Game",
                                Command = new Command(() =>
                                {
                                    homePageViewModel.ResetActualGame();
                                    Navigation.PushAsync(homePageViewModel.GamePage);
                                }),
                            }.PrimaryButton()
                            .Bind(Button.IsVisibleProperty, nameof(HomePageViewModel.GameExists)),
                            new Button()
                            {
                                Text = "New Game",
                                Command = new Command(() =>
                                {
                                    homePageViewModel.Reset();
                                    Navigation.PushAsync(homePageViewModel.GamePage);
                                }),
                            }.PrimaryButton(),
                            new Button()
                            {
                                Text = "Exit",
                                Command = new Command(() =>
                                {
                                    System.Environment.Exit(0);
                                }),
                            }.PrimaryButton()

                }
            };
        }
    }
}
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using RockPaperScissors.Converters;
using RockPaperScissors.Models;
using RockPaperScissors.Pages;
using RockPaperScissors.ViewModels;
using RockPaperScissors.ViewModels.Factories;
using RockPaperScissors.Views.Game;

namespace RockPaperScissors
{
    public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			builder.Services.AddScoped<IGameItemToImageSource, GameItemToImageSource>();
			builder.Services.AddScoped<IPlayerViewModelFactory, PlayerViewModelFactory>();
			builder.Services.AddScoped<IResultViewModelFactory, ResultViewModelFactory>();
			builder.Services.AddScoped<IPlayGroundViewModelFactory, PlayGroundViewModelFactory>();
			builder.Services.AddScoped<IPlayGround, PlayGround>();
			builder.Services.AddSingleton<PlayerView>();
			builder.Services.AddSingleton<PlayGroundView>();
			builder.Services.AddSingleton<ResultView>();
			builder.Services.AddSingleton<MainPageViewModel>();
			builder.Services.AddSingleton<GamePage>();
			builder.Services.AddSingleton<HomePageViewModel>();
			builder.Services.AddSingleton<HomePage>();
			return builder.Build();
		}
	}
}
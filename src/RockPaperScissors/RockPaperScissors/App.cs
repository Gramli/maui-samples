using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using RockPaperScissors.Views;

namespace RockPaperScissors
{
    public class App : Microsoft.Maui.Controls.Application
    {
		public App(HomePage homePage)
		{
			MainPage = new NavigationPage(homePage);
		}
	}
}

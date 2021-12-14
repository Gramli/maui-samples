using Microsoft.Maui.Controls;
using RockPaperScissors.Views;
using Application = Microsoft.Maui.Controls.Application;

namespace RockPaperScissors
{
    public partial class App : Application
	{
		public App(HomePage homePage)
		{
			InitializeComponent();

			MainPage = new NavigationPage(homePage);
		}
	}
}

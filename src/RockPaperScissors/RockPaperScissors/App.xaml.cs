using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace RockPaperScissors
{
	public partial class App : Application
	{
		public App(MainPage mainPage)
		{
			InitializeComponent();

			MainPage = mainPage;
		}
	}
}

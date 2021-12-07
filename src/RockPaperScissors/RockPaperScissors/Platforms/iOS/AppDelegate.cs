using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace RockPaperScissors
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}
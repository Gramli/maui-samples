using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace SwapiClient
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => App.CreateMauiApp();
	}
}
using System;
using System.Linq;
using Comet.Graphics;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Hosting;
using System.Collections.Generic;
using Comet;
using System.IO;

namespace SwapiClient
{
    public class App : CometApp
    {
        [Body]
        View view() => new MainPage();

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseCometApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
//-:cnd
#if DEBUG
			builder.EnableHotReload();
#endif
//+:cnd
            return builder.Build();
        }
    }
}

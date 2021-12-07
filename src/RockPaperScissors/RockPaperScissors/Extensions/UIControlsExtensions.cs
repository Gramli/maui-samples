using Microsoft.Maui.Controls;

namespace RockPaperScissors.Extensions
{
    internal static class UIControlsExtensions
    {
        public static Image SetCentered100pxImage(this Image image)
        {
            image.HeightRequest = 100;
            image.WidthRequest = 100;
            image.HorizontalOptions = LayoutOptions.Center;
            image.VerticalOptions = LayoutOptions.Center;
            return image;
        }

        public static ImageButton SetCentered100pxImageButton(this ImageButton button)
        {
            button.HeightRequest = 100;
            button.WidthRequest = 100;
            button.HorizontalOptions = LayoutOptions.Center;
            button.VerticalOptions = LayoutOptions.Center;
            button.BackgroundColor = KnownColor.Transparent;

            return button;
        }

        public static ContentView Center(this ContentView contentView)
        {
            contentView.VerticalOptions = LayoutOptions.Center;
            return contentView;
        }
    }
}

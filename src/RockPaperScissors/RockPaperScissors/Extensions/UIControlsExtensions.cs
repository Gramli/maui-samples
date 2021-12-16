using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

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

        public static ImageButton SetCentered100pxImageButton(this ImageButton button, Color backgroundColor = default)
        {
            button.HeightRequest = 100;
            button.WidthRequest = 100;
            button.HorizontalOptions = LayoutOptions.Center;
            button.VerticalOptions = LayoutOptions.Center;
            button.BackgroundColor = backgroundColor == default ? KnownColor.Transparent : backgroundColor;

            return button;
        }

        public static Label SetBoldLabel(this Label label)
        {
            label.FontSize = 18;
            label.FontAttributes = FontAttributes.Bold;

            return label;
        }

        public static Button PrimaryButton(this Button button)
        {
            button.BackgroundColor = Color.FromArgb("06BEE1");
            button.FontSize = 18;
            button.FontAttributes = FontAttributes.Bold;
            button.Margin = 5;
            return button;
        }
    }
}

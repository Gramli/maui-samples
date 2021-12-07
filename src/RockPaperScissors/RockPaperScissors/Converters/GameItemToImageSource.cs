using Microsoft.Maui.Controls;
using RockPaperScissors.Models;

namespace RockPaperScissors.Converters
{
    internal class GameItemToImageSource : IGameItemToImageSource
    {
        public ImageSource Convert(GameItem gameItem)
        {
            switch (gameItem)
            {
                case GameItem.Paper:
                    return "icons8_roll_of_paper_100px.png";
                case GameItem.Rock:
                    return "icons8_rock_100px.png";
                case GameItem.Scissors:
                    return "icons8_scissors_100px.png";
                default:
                    return null;
            }
        }
    }
}

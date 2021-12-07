using Microsoft.Maui.Controls;
using RockPaperScissors.Models;

namespace RockPaperScissors.Converters
{
    public interface IGameItemToImageSource
    {
        ImageSource Convert(GameItem gameItem);
    }
}

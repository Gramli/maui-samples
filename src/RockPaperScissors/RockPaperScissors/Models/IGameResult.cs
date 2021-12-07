using RockPaperScissors.Patterns.Mediator;

namespace RockPaperScissors.Models
{
    public interface IGameResult : IMessageObject
    {
        Winner Winner { get; }
        GameItem Player { get; }
        GameItem Enemy { get; }
    }
}

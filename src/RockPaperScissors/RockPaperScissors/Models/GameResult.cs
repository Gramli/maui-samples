namespace RockPaperScissors.Models
{
    public record GameResult : IGameResult
    {
        public Winner Winner { get; init; }

        public GameItem Player { get; init; }

        public GameItem Enemy { get; init; }
    }
}

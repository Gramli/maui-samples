using System;

namespace RockPaperScissors.Models
{ 
    public interface IPlayGround : IGameReset
    {
        bool IsPlaying { get; }
        void SetPlayerSelection(GameItem gameItem);
        void GenerateRandomEnemySelection();
        event EventHandler<IGameResult> OnResult;
    }
}

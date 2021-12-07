using System;

namespace RockPaperScissors.Models
{
    public class PlayGround : IPlayGround
    {
        public bool IsPlaying { get; private set; }

        public event EventHandler<IGameResult> OnResult;

        private GameItem _playerGameItem = GameItem.None;
        private GameItem _EnemyGameItem = GameItem.None;
        private readonly Random _random = new();
        public void Reset()
        {
            IsPlaying = false;
            _EnemyGameItem = GameItem.None;
            _playerGameItem = GameItem.None;
        }

        public void GenerateRandomEnemySelection()
        {
            _EnemyGameItem = (GameItem)_random.Next(0, 2);
            TryEvaluate();
        }

        public void SetPlayerSelection(GameItem gameItem)
        {
            _playerGameItem = gameItem;
            TryEvaluate();
        }

        private void TryEvaluate()
        {
            if (_playerGameItem == GameItem.None || _EnemyGameItem == GameItem.None)
            {
                return;
            }

            IsPlaying = true;
            OnResult?.Invoke(this, new GameResult() { Enemy = _EnemyGameItem, Player = _playerGameItem, Winner = GetWinner() });
        }

        private Winner GetWinner()
        {
            if(_EnemyGameItem == _playerGameItem)
            {
                return Winner.Tie;
            }

            return _playerGameItem switch
            {
                GameItem.Paper when _EnemyGameItem != GameItem.Scissors => Winner.Player,
                GameItem.Rock when _EnemyGameItem != GameItem.Paper => Winner.Player,
                GameItem.Scissors when _EnemyGameItem != GameItem.Rock => Winner.Player,
                _ => Winner.Enemy,
            };
        }
    }
}

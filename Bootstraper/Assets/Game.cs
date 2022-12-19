using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

namespace Core
{

    public class Game 
    {
        public const int PlAYER_SCORE = 3;
        [SerializeField] private Score _score;

        public Game(Score _score)
        {
            this._score = _score;
            SartGame();
        }
        private void SartGame()
        {
            _score.NowScore = PlAYER_SCORE;

        }

        public void Quit()
        {
            _score.NowScore = 0;
        }
    }
}
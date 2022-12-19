using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private GetCklick _getCklick;
        [SerializeField] private Quit _quit;
        [SerializeField] private ScoreTxt _scoreTxt;
        [SerializeField] private Game _game;
        [SerializeField] Score _score;

        private void Awake()
        {
            _score = new Score(_scoreTxt);

            _getCklick.Score = _score;

            _scoreTxt.Score = _score;

            _game = new Game(_score);

            _quit.Game = _game;

        }
    }
}
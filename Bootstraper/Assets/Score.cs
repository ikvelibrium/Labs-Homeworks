using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

namespace ScoreSystem
{
    public class Score
    {
        [SerializeField] private ScoreTxt _scoreTxt;

        
        public Score(ScoreTxt _scoreTxt)
        {
            this._scoreTxt = _scoreTxt;
        }
        [SerializeField] private int _nowScore;
        public int NowScore
        {
            get => _nowScore;
            set
            {
                _nowScore = value;
                _scoreTxt.Transfer_action?.Invoke();
            }
        }
    }

}
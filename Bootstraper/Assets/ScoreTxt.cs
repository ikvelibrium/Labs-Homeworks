using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using ScoreSystem;


namespace Core
{
    public class ScoreTxt : MonoBehaviour
    {
       
        [SerializeField] private TMP_Text _scorePoints;
        [SerializeField] private Score _score;
        public UnityAction Transfer_action;
        public Score Score
        {
            get => _score;

            set
            {
                _score = value;

            }
        }
        
        private void Awake()
        {

            _scorePoints = GetComponent<TMP_Text>();
            Transfer_action += ChangeScore;


        }



        void ChangeScore()
        {
            _scorePoints.text = "Score: " + _score.NowScore;   
        }
    }
}
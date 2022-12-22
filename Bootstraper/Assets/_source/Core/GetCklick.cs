using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

namespace Core
{
    public class GetCklick : MonoBehaviour
    {
        private Rigidbody rb;
        [SerializeField] private Score _score;


        public Score Score
        {
            get => _score;
            set
            {
                _score = value;
            }
        }


        private void OnMouseOver()
        {
           
            if (Input.GetMouseButtonDown(0))
            {
            
                _score.NowScore++;

            }
        }


        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            //rb.AddForce(Vector3.right * 10, ForceMode.Impulse);
        }
    }
}
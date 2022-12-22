using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class Quit : MonoBehaviour
    {
        [SerializeField] private Game _game;
        public Game Game
        {
            get => _game;
            set
            {
                _game = value;

            }
        }
        void Update()
        {


            if (Input.GetKeyDown(KeyCode.Escape))
            {

                _game.Quit();

            }
        }
    }
}
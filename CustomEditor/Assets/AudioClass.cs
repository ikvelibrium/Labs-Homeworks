using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AudioClass 
{

    [SerializeField] private AudioClip _audioClip;
    [SerializeField] [Range(0, 1)] private float _volume;
}

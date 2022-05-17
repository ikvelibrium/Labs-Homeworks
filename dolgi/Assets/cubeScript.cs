using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    [SerializeField] private Transform[] cubes;


    void Start()
    {
        for (int i = 0; i < cubes.Length - 1; i++)
        {
            for (int j = 0; j < cubes.Length - i - 1; j++)
            {
                if (cubes[j].localScale.magnitude > cubes[j + 1].localScale.magnitude)
                {
                    Transform cnt = cubes[j];
                    cubes[j] = cubes[j + 1];
                    cubes[j + 1] = cnt;
                }
            }
        }
        Vector3 spawnPoint = new Vector3(0, 0, 0);
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i].transform.position = spawnPoint;
            if (i + 1 != cubes.Length)
            {
                spawnPoint.x += cubes[i + 1].localScale.x / 2;
            }
            spawnPoint.x += cubes[i].localScale.x / 2 + 0.1f;
        }
    }



}
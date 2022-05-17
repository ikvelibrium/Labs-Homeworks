using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballJumper : MonoBehaviour
{
    [SerializeField] private Material ballcolor;
    [SerializeField] private float point;

    private float timer;
    private Rigidbody rb;
    private bool colorRed = false;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }


    void Update()
    {


        if (Mathf.Abs(rb.velocity.y) < point)
        {
            ballcolor.color = Color.red;
            timer += Time.deltaTime;
            colorRed = true;

        }
        if (colorRed == true && Mathf.Abs(rb.velocity.y) >= point)
        {
            Debug.Log(timer);
            timer = 0;
            ballcolor.color = Color.blue;
            colorRed = false;

        }
        Debug.Log(timer);
    }
}
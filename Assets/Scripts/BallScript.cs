using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool inPlay;
    public Transform platform;
    private float speed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up*500);
    }

   
    void Update()
    {
        if (!inPlay)
        {
            transform.position = platform.position;
        }

        if (Input.GetButtonDown("Jump")&&!inPlay)
        {
            inPlay = true;
            rb.AddForce(Vector2.up*speed);
        }
    }

    private void OnTriggerEnter(Collider2D other)
    {
        if (other.CompareTag("Bottom"))
        {
            Debug.Log("Ball hit the bottom of the screen");
            rb.velocity=Vector2.zero;
            inPlay = false;
        }
    }
}

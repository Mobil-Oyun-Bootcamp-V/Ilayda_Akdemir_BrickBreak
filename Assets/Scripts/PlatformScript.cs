using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public float speed;
    public float rightend;
    public float leftend;
    void Start()
    {
        
    }

    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
       transform.Translate(Vector2.right*horizontal*Time.deltaTime*speed);
       if (transform.position.x<leftend)
       {
           transform.position = new Vector2(leftend, transform.position.y);
       }
       if (transform.position.x>rightend)
       {
           transform.position = new Vector2(rightend, transform.position.y);
       }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class PlayerMovement : MonoBehaviour
{
    //public float speed = 5.5f;
    //private float horizontal;
    //private Transform playerTransform; 

    
    //void Start()
    {
        //playerTransform = GetComponent<Transform>();
    }

    
    //void Update()
    {
        //horizontal = Input.GetAxisRaw("Horizontal"); 

        // playerTransform.position  += new Vector3 (horizontal * speed * Time.deltaTime, 0, 0); 

        //playerTransform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);

    }
}

public class velocity : MonoBehaviour 
{
    private Rigidbody2D rb ;
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2 (2f ,0f);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviento_2 : MonoBehaviour
{
    private  Rigidbody2D rb;
    public float speed = 5.5f;
    private float horizontal;
    public float jumpforce = 7f; 
    private Animator animator;
    private Transform playerTransform; 

    public bool isGrounded; 
    public Transform groundSensor; 
    public LayerMask ground; 
    public float sensorRadius = 0.1f;


    private void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerTransform = GetComponent<Transform>();
    }

    void jump()
    {
        isGrounded = Physics2D.OverlapCircle(groundSensor.position, sensorRadius, ground);
        
        if(Input.GetButtonDown("Jump") && isGrounded)
        { 
            rb.AddForce(Vector2.up * jumpforce);
            animator.SetBool("Jump" , true);
        }
        else 
        {
            animator.SetBool("Jump" , false);
        }
    }
   
    private void FixedUpdate() 
    {

        //la velocidad del Rigidbody es un vector que en el eje X, mueves en horizontal dependiendo de la velocidad(multiplica)
        rb.velocity = new Vector2 (horizontal * speed, 0f);  

        if(horizontal == 0)
        {
            animator.SetBool("Run" , false);
        }  
        else if (horizontal == 1)
        {
            animator.SetBool("Run" , true); 
            playerTransform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (horizontal == -1)
        {
            animator.SetBool("Run" , true); 
            playerTransform.rotation = Quaternion.Euler(0, -180, 0);
        }

        //GameManager.Instance.RestarVidas();
        //GameManager.Instance.vidas; 
        //Global.nivel = 1;
    }
 
    //Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");
        jump();

        //playerTransform.position += new Vector3 (1, 0, 0) * horizontal * speed * Time.deltaTime;

        //playerTransform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 6)
        {
            StartCoroutine(GameObject.Find("Main Camera").GetComponent<CameraShake>().Shake());
        }
    }
}

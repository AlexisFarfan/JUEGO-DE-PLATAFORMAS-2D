using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] Animator anim;
    private float runspeed = 5;
    private float jumpforce = 8;

    Rigidbody2D rb2d;
    float desplX;
    float speed;
    float maxSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
        anim = gameObject.GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        maxSpeed = 5f;

    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetFloat("Velocidad", velocidad);

        if (Input.GetKeyDown("space") && Checkground.isGrounded) 
        {
            anim.SetTrigger("Saltar");
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpforce);
            maxSpeed = 0;
        }

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Rodar");
            
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            anim.SetBool("Agacharse", true);
        }
        
        else
        {
            anim.SetBool("Agacharse", false);
            maxSpeed = 3f;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("Correr", true);
            rb2d.velocity = new Vector2(runspeed, rb2d.velocity.y);
            maxSpeed = 10f;
        }

        else
        {
            anim.SetBool("Correr", false);
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }

    }
    private void FixedUpdate()
    {
        desplX = Input.GetAxis("Horizontal");
        // Aplicamos el movimiento
        rb2d.velocity = new Vector2(desplX * maxSpeed, rb2d.velocity.y);
        //Redondeamos la velocidad para pasarlo al parámetro del animator
        speed = Mathf.Abs(rb2d.velocity.x);
        anim.SetFloat("Velocidad", speed);
    }





}

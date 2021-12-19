using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [Header("Componentes")]
    [SerializeField] Rigidbody2D rb2d;

    [Header("Movimiento")]
    private float moveSpeed = 5;

    [Header("Salto")]
    private float jumpforce = 8;

    [Header("Animator")]
    [SerializeField] Animator anim;

    [Header("Grounded")]
    private bool isGrounded;
    public Transform groundChheckPoint;
    public LayerMask whatIsGround;
    
    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();  
        moveSpeed = 5f;
        

    }

    // Update is called once per frame
    void Update()
    {
        

        //animator.SetFloat("Velocidad", velocidad);

        if (Input.GetButtonDown("Jump") && Checkground.isIdle) 
        {
            if(isGrounded)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpforce);
            }
            anim.SetTrigger("Saltar");
            moveSpeed = 0;
            
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
            moveSpeed = 3f;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("Correr", true);
            rb2d.velocity = new Vector2(moveSpeed, rb2d.velocity.y);
            moveSpeed = 10f;
            
        }

        else
        {
            anim.SetBool("Correr", false);
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
         
    }
    private void FixedUpdate()
    {
        //desplX = Input.GetAxis("Horizontal");
        // Aplicamos el movimiento
        //rb2d.velocity = new Vector2(desplX * maxSpeed, rb2d.velocity.y);
        rb2d.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), rb2d.velocity.y);
        isGrounded = Physics2D.OverlapCircle(groundChheckPoint.position, 2f, whatIsGround);
        //Redondeamos la velocidad para pasarlo al parámetro del animator
        moveSpeed = Mathf.Abs(rb2d.velocity.x);
        anim.SetFloat("Velocidad", moveSpeed);
        
    }





}

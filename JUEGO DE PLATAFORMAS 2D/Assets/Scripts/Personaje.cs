using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] Animator anim;
    private float runspeed = 5;
    private float jumpforce = 8;

    Rigidbody2D rb2d;

    

    // Start is called before the first frame update
    void Start()
    {
        
        anim = gameObject.GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
   
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetFloat("Velocidad", velocidad);

        if (Input.GetKey("space") && Checkground.isGrounded) 
        {
            anim.SetTrigger("Saltar");
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpforce);
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
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("Correr", true);
            rb2d.velocity = new Vector2(runspeed, rb2d.velocity.y);
        }

        else
        {
            anim.SetBool("Correr", false);
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
    }

   



}

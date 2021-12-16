using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator; //Animator Controller
    float desplX;
    float speed; //variable que pasaremos al animator controller
    float maxSpeed; //variable que determina la velocidad de movimiento
    void Start()
    {
        //Accedemos al RigidBody y al Animator Controller
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        //Determinamos nuestra velocidad de desplazamiento
        maxSpeed = 5f;
    }
    private void FixedUpdate()
    {
        desplX = Input.GetAxis("Horizontal");
        // Aplicamos el movimiento
        rb.velocity = new Vector2(desplX * maxSpeed, rb.velocity.y);
        //Redondeamos la velocidad para pasarlo al parámetro del animator
        speed = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("Velocidad", speed);
    }
}

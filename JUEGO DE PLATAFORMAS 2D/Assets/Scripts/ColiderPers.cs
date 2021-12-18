using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderPers : MonoBehaviour
{
    CapsuleCollider2D bc;
    bool isCrouched = false;
    Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        //Obtenemos el BoxClollider y ponemos los datos iniciales
        bc = GetComponent<CapsuleCollider2D>();
        bc.offset = new Vector2(0f, 1.2f);
        bc.size = new Vector2(1f, 2.1f);
    }

    // Update is called once per frame
    void Update()
    {
        CambiarCollider();
    }

    void CambiarCollider()
    {
        //Si hemos puesto el parámetro agachado y no lo estamos
        if (animator.GetBool("Agacharse") && !isCrouched)
        {
            bc.offset = new Vector2(0.35f, 0.9f);
            bc.size = new Vector2(1.7f, 1.5f);
            //Decimos que está agachado para que no se ejecute más
            isCrouched = true;
        }
        //Si hemos puesto que no estamos agachado y lo estamos
        if (!animator.GetBool("Agacharse") && isCrouched)
        {
            bc.offset = new Vector2(0f, 1.2f);
            bc.size = new Vector2(1f, 2.1f);
            //Decimos que está agachado para que no se ejecute más
            isCrouched = false;
        }

       
    }
}

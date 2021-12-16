using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{
    bool mirandoDerecha = true; //Determina si estamos mirando a la derecha
    void Update()
    {
        float desplX = Input.GetAxis("Horizontal");
        //Si nos movemos a la derecha y estamos mirando a la izquierda, volteamos
        if (desplX > 0 && !mirandoDerecha)
        {
            Flip();
        }
        // En caso contrario, si nos movemos a la izquierda y miramos a la derecha
        else if (desplX < 0 && mirandoDerecha)
        {
            // giramos
            Flip();
        }
    }
    void Flip()
    {
        //Cambiamos el valor de la booleana, poniendo su valor contrario
        mirandoDerecha = !mirandoDerecha;
        //Creamos un Vector3 que es igual al de nuestra escala actual
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}

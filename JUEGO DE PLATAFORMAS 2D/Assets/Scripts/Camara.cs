using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    //Variables necesarias para la opción de suavizado
    [SerializeField] float smoothVelocity;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        transform.position = new Vector3(playerPosition.position.x, 0, playerPosition.position.z - 10);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    /* [SerializeField] Transform playerPosition;
     //Variables necesarias para la opción de suavizado
     [SerializeField] float smoothVelocity;
     [SerializeField] Vector3 camaraVelocity = Vector3.zero;
    */
    public Transform target;

    public Transform background;
    private float lastXPos;
    private float lastYPos;

    // Start is called before the first frame update
    void Start()
    {
        lastXPos = transform.position.x;
        lastYPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        // transform.position = new Vector3(playerPosition.position.x, 0, playerPosition.position.z - 10);
        transform.position = new Vector3(target.position.x, target.position.y + 3, target.position.z -1);

        float amountToMoveX = transform.position.x - lastXPos;
        float amonuntToMoveY = transform.position.y - lastYPos;
        background.position += new Vector3(amountToMoveX, amonuntToMoveY, 0f);
        lastXPos = transform.position.x;
        lastYPos = transform.position.y;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkground : MonoBehaviour
{
    public static bool isIdle;
    [SerializeField] Animator anim;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        isIdle = true;
        anim.SetBool("TocarSuelo", true);

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isIdle = false;
        anim.SetBool("TocarSuelo", false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DuggStart : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger("isOff");
            Debug.Log("충돌");
        }

    }

  /*  private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag =="Player")
        {
            anim.SetTrigger("isOff");
            Debug.Log("충돌");
        }
    }*/
}

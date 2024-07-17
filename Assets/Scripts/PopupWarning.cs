using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupWarning : MonoBehaviour
{

    public GameObject warningmsg;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            warningmsg.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        warningmsg.SetActive(false);
    }

   
}

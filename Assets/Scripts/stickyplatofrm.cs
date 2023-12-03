using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickyplatofrm : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    { 
        // Stick the player to the platform
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform); 
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        // release the player to the platform
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null); 
        }
    }
}

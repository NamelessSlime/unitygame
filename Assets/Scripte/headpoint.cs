using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headpoint : MonoBehaviour
{

    GameObject leaf;
    GameObject director;

    void OnTriggerEnter2D(Collider2D collider2D)
    { 
            GetComponent<BoxCollider2D>().isTrigger = false;
    }

    private void OnTriggerExit2D(Collider2D collider2D)
    {
            GetComponent<BoxCollider2D>().isTrigger = true;
    }
}

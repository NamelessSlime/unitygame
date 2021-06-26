using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSpawnPoint : MonoBehaviour
{
    bool re = false;

    
    void Start()
    {
        
    }


    void Update()
    {
        if (re == false)
        {
            transform.Translate(new Vector3(0.01f, 0f, 0f));
        } 
        else 
        {
            transform.Translate(new Vector3(-0.01f, 0f, 0f));
        }

        if(transform.position.x > 4)
        {
            re = true;
        }
        if(transform.position.x < 1)
        {
            re = false;
        }
    }
}

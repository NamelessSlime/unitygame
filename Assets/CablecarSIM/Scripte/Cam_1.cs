using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_1 : MonoBehaviour
{
    GameObject Player;
    void Start()
    {
        this.Player = GameObject.Find("Cablecar");
    }

    void Update()
    {
        if (this.Player.transform.position.y > -5)
        {
            Vector3 playerpos = this.Player.transform.position;
            transform.position = new Vector3(playerpos.x, playerpos.y, transform.position.z);
        }
            
    }

}

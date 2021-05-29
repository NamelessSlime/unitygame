using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    GameObject player;
    GameObject director;


    void Start()
    {
        this.player = GameObject.Find("player");
        this.director = GameObject.Find("director");
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            director.GetComponent<MainDirector>().down_score();
            gameObject.SetActive(false);
        }
    }
}

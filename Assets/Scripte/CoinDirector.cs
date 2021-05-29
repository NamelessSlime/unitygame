using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDirector : MonoBehaviour
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
            director.GetComponent<MainDirector>().rise_score();
            gameObject.SetActive(false);
        }
    }
}

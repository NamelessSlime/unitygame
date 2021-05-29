using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainDirector : MonoBehaviour
{

    public int score = 100;
    float effect_time_base = 5f;
    float effect_time_of_coin = 11f;
    float effect_time_of_speed = 6f;
    int base_coin = 10;
    int damage = 5;
    public Text scoretext;
    public GameObject[] Grounds;

    public void rise_score()
    {
        score += base_coin;
        Debug.Log(score);
        scoretext.text = "Score : " + score;
    }

    public void item_score()
    {
        score += base_coin + 5;
        Debug.Log(score);

    }

    public void down_score()
    {
        score -= base_coin + damage;

        Debug.Log(score);

         scoretext.text = "Score : " + score;
    }

    public void double_score()
    {
        effect_time_of_coin = 0;
        base_coin = 20;
        Debug.Log(score);
    }

    public void boosted(float speed)
    {
        effect_time_of_speed = 0;
        for (int i = 0; i < Grounds.Length; i++)
        {
            Grounds[i].GetComponent<BackgroundController>().speed = speed;
            damage = 10;
        }
        Debug.Log("boosted");

        
    }





    void Update()
    {
        if (effect_time_of_coin < effect_time_base)
        {
            effect_time_of_coin += Time.deltaTime;
        }
        else
        {
            base_coin = 10;
        }

        if (effect_time_of_speed < effect_time_base)
        {
            effect_time_of_speed += Time.deltaTime;
        }
        else
        {
            boosted(10);
            damage = 5;
        }
    }
}

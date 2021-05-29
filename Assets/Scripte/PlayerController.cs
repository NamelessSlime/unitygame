using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public float jumpForce = 40f;

    public int jumpCount = 0;
    public bool isGrouned = false;
    public bool isDead = false;
    int score;

    private Rigidbody2D playerRigidbody;
    public GameObject foot;
    public GameObject head;

    GameObject director;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        director = GameObject.Find("director");
        head = GameObject.Find("head");
       
    }


    private void Update()
    {
        score = director.GetComponent<MainDirector>().score;
        if (isDead)
        {
            return;
        }


        if (transform.position.y < -5.25f)
        {
            Die();
        }

        if (score <= 0)
        {
            Die();
        }

        if (Input.GetMouseButton(0) && jumpCount < 1)
        {
            jumpCount++;
            playerRigidbody.velocity = Vector2.zero;
            playerRigidbody.AddForce(new Vector2(0, jumpForce));
        }
        else if (Input.GetMouseButtonUp(0) && playerRigidbody.velocity.y > 0)
        {
            playerRigidbody.velocity = playerRigidbody.velocity * 0.4f;
        }
    }

    private void Die()
    {
        isDead = true;
        Debug.Log("die");
        SceneManager.LoadScene("SampleScene");


    }


    void OnCollisionEnter2D(Collision2D boxCollision2D)
    {
            Debug.Log("땅에닿음");
            isGrouned = true;
            jumpCount = 0;
    }
}

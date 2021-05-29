using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CableCarController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D))
        {
            rigidbody2d.AddForce(new Vector2(50.0f, 0));
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A))
        {
            rigidbody2d.AddForce(new Vector2(-50.0f, 0));
        }


    }
}

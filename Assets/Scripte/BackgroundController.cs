using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour

{
    public GameObject[] treePos;
    public GameObject[] scorePos;

    public float speed = 10f;
    public bool isStart;

    
    private void treeReset()
    {

        for (int i = 0; i < treePos.Length; i++)
        {
            for (int j = 0; j < 3; j++)
                treePos[i].transform.GetChild(j).gameObject.SetActive(false);

            if (Random.Range(0f, 1f) < 0.975f)
            {
                
                treePos[i].transform.GetChild(Random.Range(0, 3)).gameObject.SetActive(true);
            }
 
        }
    }

    public void CoinReset()
    {

        for (int i = 0; i < scorePos.Length; i++)
        {
            for (int j = 0; j < scorePos.Length; j++)
            {
                scorePos[i].SetActive(false);
                for (int k = 0; k < 4; k++)
                    scorePos[i].transform.GetChild(k).gameObject.SetActive(false);
            }

            if (Random.Range(0f, 1f) < 0.7f)
            {

                scorePos[i].SetActive(true);
                scorePos[i].transform.GetChild(Random.Range(0, 4)).gameObject.SetActive(true);
            }

        }
    }

    void Start()
    {
        treeReset();
        CoinReset();
        if (isStart)
        {
            for (int i = 0; i < treePos.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    treePos[i].transform.GetChild(j).gameObject.SetActive(false);
                    scorePos[i].transform.GetChild(j).gameObject.SetActive(false);
                }

            }
        }

    }


    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.left * speed*5/7 * Time.deltaTime);

        if (transform.position.x < -18)
        {
            transform.position = new Vector2(33.54f, transform.position.y);
            treeReset();
            CoinReset();
        }

    }
}

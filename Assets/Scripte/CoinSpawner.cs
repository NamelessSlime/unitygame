using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject[] scorePos;

    public void CoinReset()
    {

        for (int i = 0; i < scorePos.Length; i++)
        {
            for (int j = 0; j < scorePos.Length; j++)
                scorePos[i].SetActive(false);

            if (Random.Range(0f, 1f) < 0.2f)
            {

                scorePos[i].SetActive(true);
            }

        }
    }

    void Start()
    {
        CoinReset();
    }

    void Update()
    {
        
    }
}

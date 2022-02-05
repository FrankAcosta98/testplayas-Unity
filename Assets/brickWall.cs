using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickWall : MonoBehaviour
{
    public GameObject brick;
    public Light luz;
    private Vector3 pos = Vector3.zero;
    private GameObject chosen;
    private Light lt;

    private GameObject[,] wall = new GameObject[14, 10];

    private GameObject lastC;
    // Start is called before the first frame update
    void Awake()
    {

        lt = GameObject.Instantiate(luz, transform.position, Quaternion.identity);

        for (int i = 0; i < 14; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                //GameObject.Instantiate(brick, transform.position + pos, Quaternion.identity);

                wall[i, j] = GameObject.Instantiate(brick, transform.position + pos, Quaternion.identity);
                pos.x += 2.6f;
            }
            if (i % 2 == 0)//! si es par
                pos.x = 1.3f;
            else
                pos.x = 0f;

            pos.y += 1.1f;
        }
        lastC = wall[0, 0];

        InvokeRepeating("choose", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void choose()
    {
        if (!lastC.activeSelf)// ! si NO esta activo
            lastC.SetActive(true);

        chosen = wall[Random.Range(0, 14), Random.Range(0, 10)];
        chosen.SetActive(false);
        lt.transform.position = chosen.transform.position;
        lastC = chosen;
    }

}

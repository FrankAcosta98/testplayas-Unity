using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject player;
    private bool follow = false;
    public float speed = 2f;
    void Awake()
    {//                             la sphere
        
    }

    void Update()
    {
        if (follow)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * speed);
        }
        if ((Vector3.Distance(transform.position, player.transform.position) < 1.5f))
        {
            Destroy(player);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        player = other.gameObject;
        follow = true;

    }
    void OnTriggerExit(Collider other)
    {

        follow = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class losewin : MonoBehaviour
{
    private int l;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Sphere").GetComponent<Ball>().count >= 30)
        {
            Debug.Log("ganaste");
        }
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        l++;
        Debug.Log("perdiste " + l + " veces");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizo : MonoBehaviour
{
    public Transform a;
    public Transform b;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(a.rotation, b.rotation, Mathf.PingPong(Time.time,1f));
    }
}

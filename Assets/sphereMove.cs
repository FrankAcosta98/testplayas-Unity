using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMove : MonoBehaviour
{
    public Rigidbody rb;
    public float power=2f;
    public GameObject bola;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {//                             -1 <-0-> +1
        if(Input.GetAxis("Horizontal")<0)
            rb.AddForce(Vector3.left * power);
        if (Input.GetAxis("Horizontal") > 0)
            rb.AddForce(Vector3.right * power);
            
        if (Input.GetAxis("Vertical") > 0)
            rb.AddForce(Vector3.forward * power);
        if (Input.GetAxis("Vertical") < 0)
            rb.AddForce(Vector3.back * power);
    }
}

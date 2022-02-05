using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolStick : MonoBehaviour
{
    public GameObject bola;
    public float power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space)){
            GetComponent<Rigidbody>().AddForce(Vector3.forward*power);
        }
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float spd = 6.5f;
    public Vector3 force;
    [HideInInspector]
    public int count;
    public GameObject slider;
    private bool start = true;
    // Start is called before the first frame update
    void Awake()
    {
        transform.SetParent(slider.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && start)
        {
            transform.parent = null;
            rb.velocity = (force);
            start = false;
        }
        rb.velocity = rb.velocity.normalized * spd;
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.name.Contains("Brick"))
        {
            Destroy(other.gameObject, 0.01f);
            count++;
        }
    }
}



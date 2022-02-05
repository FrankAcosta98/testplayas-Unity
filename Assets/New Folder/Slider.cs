using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    public float spd = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0f)
            transform.position = Vector3.MoveTowards(transform.position, Vector3.right * 10, spd * Time.deltaTime);
        if (Input.GetAxis("Horizontal") < 0f)
            transform.position = Vector3.MoveTowards(transform.position, Vector3.left * 10, spd * Time.deltaTime);
    }
}

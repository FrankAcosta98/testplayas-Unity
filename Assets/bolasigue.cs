using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolasigue : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 2f)
            GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * 4f));
    }
}

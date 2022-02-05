using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {
        //! mierda que nadie ocupa hacer
        for (var i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
        //!----------
    }

    // Update is called once per frame
    void Update()
    {

    }
}

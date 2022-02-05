using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gererator : MonoBehaviour
{
    private Vector3 tempPos = new Vector3(-9, 6, 0);
    private int indx;

    public PhysicMaterial bounce;

    // Start is called before the first frame update
    void Awake()
    {
        InvokeRepeating("CreateFloor", 0, .2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (indx > 5)
            CancelInvoke();
    }
    void CreateFloor()
    {
        if (indx < 5)
        {
            for (int i = 0; i < 6; i++)
            {
                GameObject tile = GameObject.CreatePrimitive(PrimitiveType.Cube);
                tile.transform.parent = transform;
                tile.name = "Brick";
                tile.transform.localScale = new Vector3(1.5f, 0.5f, 1f);
                tile.transform.position = tempPos;
                //tile.AddComponent(typeof(Rigidbody));
                //tile.GetComponent<BoxCollider>().material = bounce;
                //tile.GetComponent<Rigidbody>().useGravity = false;
                //tile.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePosition;
                tempPos.x += 3.6f;
                tile.GetComponent<Renderer>().material.color = Random.ColorHSV();
            }
            tempPos.x = -9f;
            tempPos.y += 1.5f;
            indx++;
        }
    }
}

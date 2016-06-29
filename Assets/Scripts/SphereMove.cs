using UnityEngine;
using System.Collections;

public class SphereMove : MonoBehaviour
{

    float addForce;
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        addForce = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y > 1)
        {
            addForce = 0;
        }
        if (transform.position.y < 0)
        {
            addForce = 4;
        }

        rb.AddForce(Vector3.up * addForce * Time.deltaTime);


    }
}


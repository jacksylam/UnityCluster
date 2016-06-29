using UnityEngine;
using System.Collections;

public class CubeAutomate : MonoBehaviour
{

    float addForce;

    // Use this for initialization
    void Start()
    {

        addForce = 5;

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x > 5)
        {
            addForce = -5;
        }
        if (transform.position.x < -5)
        {
            addForce = 5;
        }

        transform.Translate(transform.right * addForce * Time.deltaTime);


    }
}

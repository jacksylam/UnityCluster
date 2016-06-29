using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{

    CharacterController charController;
    // Use this for initialization
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        charController.Move(charController.transform.forward * Input.GetAxis("Vertical") * Time.deltaTime);
        charController.transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * 50 * Time.deltaTime);

    }
}

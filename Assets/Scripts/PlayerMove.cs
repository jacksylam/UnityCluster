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
        if (Input.GetKey(KeyCode.W)) {
            charController.Move(charController.transform.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) {
            charController.Move(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            charController.Move(Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            charController.Move(Vector3.back * Time.deltaTime);
        }

       // charController.Move(charController.transform.forward * Input.GetAxis("Vertical") * Time.deltaTime);
        //charController.transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * 50 * Time.deltaTime);

    }
}

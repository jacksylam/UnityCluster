using UnityEngine;
using System.Collections;

public class ScreenReso : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.SetResolution(1360, 768,false);
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.P))
        {
            Screen.SetResolution(24480, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            Screen.SetResolution(23120, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            Screen.SetResolution(21760, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            Screen.SetResolution(20400, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            Screen.SetResolution(19040, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            Screen.SetResolution(17680, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            Screen.SetResolution(16320, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Screen.SetResolution(14960, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Screen.SetResolution(13600, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Screen.SetResolution(12240, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            Screen.SetResolution(10880, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            Screen.SetResolution(9520, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            Screen.SetResolution(8160, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            Screen.SetResolution(6800, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            Screen.SetResolution(5440, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            Screen.SetResolution(4080, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Screen.SetResolution(2720, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            Screen.SetResolution(1360, 768, false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Screen.SetResolution(640, 480, false);
        }

    }
}

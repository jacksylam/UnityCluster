using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class Fps : MonoBehaviour {

    public float refreshTime = 1.0f;
    int frameCounter = 0;
    float timeCounter = 0.0f;
    float fps = 0.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (timeCounter < refreshTime) {
            timeCounter = timeCounter + Time.deltaTime;
            frameCounter++;
        }
        else {
            fps = frameCounter / timeCounter;
            frameCounter = 0;
            timeCounter = 0.0f;
        }
	}

    void OnGUI() {
        GUI.Label(new Rect(0, 0, 100, 100), fps.ToString());
    }
}

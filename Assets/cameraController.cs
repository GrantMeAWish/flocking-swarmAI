using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    private Rigidbody rb;
    private string leftControl;

	// Use this for initialization
	void Start () {
        string[] controllers = Input.GetJoystickNames();

        for (int i = 0; i < controllers.Length; i++)
        {
            if (controllers[i] == "Oculus Touch - Left")
            {
                leftControl = controllers[i];
            }
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("VRHorizontal");
        float moveVertical = Input.GetAxis("VRVertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement);
	}
}

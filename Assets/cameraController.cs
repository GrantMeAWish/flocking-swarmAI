using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    //camera movement speed
    public float speed;

    //apply physics to camera
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        
        //print connected joysticks
        string[] joysticks = Input.GetJoystickNames();
        for (int i = 0; i < joysticks.Length; i++)
        {
            print(joysticks[i] + " " + i.ToString());
        }
    }
	
    //assign joystick movement as camera velocity
	private void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("VRHorizontal");
        float moveVertical = Input.GetAxis("VRVertical");

        rb.velocity = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed;
	}
}

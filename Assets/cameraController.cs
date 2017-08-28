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
<<<<<<< HEAD
=======

>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
        
        //print connected joysticks
        string[] joysticks = Input.GetJoystickNames();
        for (int i = 0; i < joysticks.Length; i++)
        {
<<<<<<< HEAD
            print(joysticks[i] + " " + i.ToString());
        }
=======
            print(joysticks[i] + i.ToString());
        }
        
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
    }
	
    //assign joystick movement as camera velocity
	private void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("VRHorizontal");
        float moveVertical = Input.GetAxis("VRVertical");

        rb.velocity = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed;
	}
}

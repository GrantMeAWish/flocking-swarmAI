using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalController : MonoBehaviour {

    //goal movement speed
    public float speed;
<<<<<<< HEAD
    public float delta = 1.5f;  // Amount to move left and right from the start point
    private Vector3 startPos;
    public static Vector3 currentPos; 
=======
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56

    //apply physics to goal marker
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
<<<<<<< HEAD
        startPos = transform.position; 
	}

    void Update()
    {
        Vector3 v = startPos;
        v.z += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
        currentPos = v; 
    }
    /*
    //apply force vector to goal marker
    private void FixedUpdate ()
=======
	}
	
    //apply force vector to goal marker
	private void FixedUpdate ()
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
<<<<<<< HEAD
	} */
=======
	}
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
}

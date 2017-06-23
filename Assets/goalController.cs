using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalController : MonoBehaviour {

    //goal movement speed
    public float speed;

    //apply physics to goal marker
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
    //apply force vector to goal marker
	private void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalController : MonoBehaviour {

    //goal movement speed
    public float speed;
    public float delta = 1.5f;  // Amount to move left and right from the start point
    private Vector3 startPos;
    public static Vector3 currentPos; 

    //apply physics to goal marker
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
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
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
	} */
}

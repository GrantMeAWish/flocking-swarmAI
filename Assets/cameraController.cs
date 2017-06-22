﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("VRHorizontal");
        float moveVertical = Input.GetAxis("VRVertical");

        rb.velocity = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed;
	}
}

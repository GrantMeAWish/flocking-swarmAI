﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flock : MonoBehaviour {

<<<<<<< HEAD
	//bug speed and boundaries
	public float speed = 0.0005f;
    public float lowerBound = 2.5f;
    public float upperBound = 3f; 
=======
	//bug speed
	public float speed = 0.0005f;
    public float lowerbound = 2.5f;
    public float upperbound = 3f; 
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56

	//how fast bug will turn
	float rotSpeed = 4.0f;

	//max distance bugs can be to flock
	float neighborDist = 2.0f;

	bool turning = false;

    //initializing speed multiplier controlled by slider
    public float speedMult = 1;

	// Use this for initialization
	void Start()
	{
<<<<<<< HEAD
        //initialize speed and audio pitch; must be in Update() since I have it as a slider
        speed = Random.Range(lowerBound, upperBound);
        AudioSource audioSource = this.gameObject.GetComponent<AudioSource>();

        //calculate pitch w.r.t. speed
        audioSource.pitch = speed / 3 + 1;
=======
		speed = Random.Range(lowerbound, upperbound);
        AudioSource audioSource = this.gameObject.GetComponent<AudioSource>();
        audioSource.pitch = speed / 3 + 1; //Formula to calculate pitch w.r.t speed
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
	}

	// Update is called once per frame
	void Update()
	{
<<<<<<< HEAD
		speed = Random.Range(lowerBound, upperBound);
		AudioSource audioSource = this.gameObject.GetComponent<AudioSource>();
        audioSource.pitch = speed / 3 + 1;

=======
		//Initializes speed and audio pitch; must be in Update() since I have it as a slider
		speed = Random.Range(lowerbound, upperbound);
		AudioSource audioSource = this.gameObject.GetComponent<AudioSource>();
		audioSource.pitch = speed / 3 + 1; //Formula to calculate pitch w.r.t speed
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
		//bug needs to turn back into colony if distance of bug from center is larger than colonySize
		if (Vector3.Distance(transform.position, Vector3.zero) >= globalFlock.colonySize)
		{
			turning = true;
		}
		else
		{
			turning = false;
		}

		//calculate direction back towards center of colony and turn bug back in that direction
		if (turning)
		{
			Vector3 direction = Vector3.zero - transform.position;
			transform.rotation = Quaternion.Slerp(transform.rotation,
									  Quaternion.LookRotation(direction),
									  rotSpeed * Time.deltaTime);
<<<<<<< HEAD
            speed = Random.Range(lowerBound, upperBound) * speedMult;
=======
            speed = Random.Range(lowerbound, upperbound) * speedMult;
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
		}
		else
		{
			//flock every so often
			if (Random.Range(0, 5) < 1)
			{
                Flocking();
            }
        }
        transform.Translate(0, 0, Time.deltaTime * speed * speedMult);
    }

	//flock using flocking rules
	void Flocking()
	{
		GameObject[] gameObjs = globalFlock.allBugs;
		float groupSpeed = 0.1f;

		/**instantiate vectors for rules 1 and 3 of flocking; go towards center of group & 
         * avoid collisions with neighbors */
		Vector3 centerVec = Vector3.zero;
		Vector3 avoidVec = Vector3.zero;

		Vector3 goalPos = globalFlock.goalPos;

		float dist;

		int groupSize = 0;
		foreach (GameObject gameObj in gameObjs)
		{
			if (gameObj != this.gameObject)
			{
				dist = Vector3.Distance(gameObj.transform.position, this.transform.position);

				//only account for neighbor bugs close enough to form group
				if (dist <= neighborDist)
				{

					//add up center vectors for group and increment the group size each time
					centerVec += gameObj.transform.position;
					groupSize += 1;

					//calculate and add up avoid vectors to prevent collisions if distance too close
					if (dist < 1.0f)
					{
						avoidVec += (this.transform.position - gameObj.transform.position);
					}

					//grab flock script from neighbor bug and sum up speeds
					flock anotherFlock = gameObj.GetComponent<flock>();
					groupSpeed += anotherFlock.speed;
				}
			}
		}

<<<<<<< HEAD
=======

>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
		if (groupSize > 0)
		{
			//calculate average center and speed of group
			centerVec = centerVec / groupSize + (goalPos - this.transform.position);
            speed = groupSpeed / groupSize * speedMult;

			//change bug direction after determining the new direction vector
			Vector3 direction = (centerVec + avoidVec) - this.transform.position;
			if (direction != Vector3.zero)
			{
				transform.rotation = Quaternion.Slerp(transform.rotation,
													  Quaternion.LookRotation(direction),
													  rotSpeed * Time.deltaTime);
			}
		}
	}
}

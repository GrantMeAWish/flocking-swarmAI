﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalFlock : MonoBehaviour {

	//read in the bug and goal prefabs
	public GameObject bugPrefab;
	public GameObject goalPrefab;
<<<<<<< HEAD

	//instantiating colony box dimensions
	public static int colonySize = 30;
=======
	public float lowerbound;
	public float upperbound; 
	//instantiating colony box dimensions
	public static int colonySize = 10;
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
    
    //instantiating the swarm colony
    static int numBugs = 400;
	public static GameObject[] allBugs = new GameObject[numBugs];

	//instantiating goal position
	public static Vector3 goalPos = Vector3.zero;

    //distance from camera to destination point
    public float cameraDist;

<<<<<<< HEAD
    //instantiating speed boundaries
    public float lowerBound;
    public float upperBound;

=======
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
    //set bug speedMult to be the slider's multiplier
    public void BugSpeed(float speedMult) 
    {
        Debug.Log(speedMult);
		if (speedMult == 1) {
<<<<<<< HEAD
			for (int i = 0; i < numBugs; i++) {
				//allBugs[i].GetComponent<flock>().speedMult = speedMult;
				allBugs[i].GetComponent<flock>().lowerBound = 3f;
				allBugs[i].GetComponent<flock>().upperBound = 4f;
			}
			
		} else {
			for (int i = 0; i < numBugs; i++) {
				//allBugs[i].GetComponent<flock>().speedMult = speedMult;
				allBugs[i].GetComponent<flock>().lowerBound = 8.5f;
				allBugs[i].GetComponent<flock>().upperBound = 9f;
			}
		}

		for (int i = 0; i < numBugs; i++) {
			allBugs[i].GetComponent<flock>().lowerBound = speedMult + 0.5f;
			allBugs[i].GetComponent<flock>().upperBound = speedMult + 1f;
		}
=======
			for (int i = 0; i < numBugs; i += 1) {
				//allBugs[i].GetComponent<flock>().speedMult = speedMult;
				allBugs[i].GetComponent<flock>().lowerbound = 3f;
				allBugs[i].GetComponent<flock>().upperbound = 4f;

			}
			
		} else {
			for (int i = 0; i < numBugs; i += 1) {
				//allBugs[i].GetComponent<flock>().speedMult = speedMult;
				allBugs [i].GetComponent<flock> ().lowerbound = 8.5f;
				allBugs [i].GetComponent<flock> ().upperbound = 9f;

			}
			
		}

		for (int i = 0; i < numBugs; i += 1) {
			allBugs [i].GetComponent<flock> ().lowerbound = speedMult + 0.5f;
			allBugs [i].GetComponent<flock> ().upperbound = speedMult + 1f;

		}

>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
    }

	// Use this for initialization
	void Start()
	{
		for (int i = 0; i < numBugs; i += 1)
		{
			Vector3 pos = new Vector3(Random.Range(-colonySize, colonySize),
									  Random.Range(-colonySize, colonySize),
									  Random.Range(-colonySize, colonySize));
            allBugs[i] = (GameObject)Instantiate(bugPrefab, pos, Quaternion.identity);
<<<<<<< HEAD
			allBugs[i].GetComponent<flock>().lowerBound = lowerBound;
			allBugs[i].GetComponent<flock>().upperBound = upperBound;
            allBugs[i].AddComponent<playAudio>();
=======
			allBugs[i].GetComponent<flock>().lowerbound = lowerbound;
			allBugs[i].GetComponent<flock>().upperbound = upperbound;
            //allBugs[i].AddComponent<playAudio>();
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
        }
	}

	// Update is called once per frame
	void Update()
	{
        /*
        //move goal to another location within the colony at random timeframes
        if (Random.Range(0, 10000) < 50)
		{
			goalPos = new Vector3(Random.Range(-colonySize, colonySize),
									  Random.Range(-colonySize, colonySize),
									  Random.Range(-colonySize, colonySize));
            goalPrefab.transform.position = goalPos;
        } */
        /*
        //allow bugs to follow user-controlled goal marker
        goalPos = goalPrefab.transform.position; */
<<<<<<< HEAD

        //allow bugs to follow camera view
        //goalPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, cameraDist));
        goalPos = goalController.currentPos; 
=======
        
        //allow bugs to follow camera view
        goalPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, cameraDist));
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
    }
}

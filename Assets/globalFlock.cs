﻿﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalFlock : MonoBehaviour {

	//read in the bug and goal prefabs
	public GameObject bugPrefab;
	public GameObject goalPrefab;

	//instantiating colony box dimensions
	public static int colonySize = 10;
    
    //instantiating the swarm colony
    static int numBugs = 400;
	public static GameObject[] allBugs = new GameObject[numBugs];

	//instantiating goal position
	public static Vector3 goalPos = Vector3.zero;

    //distance from camera to destination point
    public float cameraDist;

    //set bug speedMult to be the slider's multiplier
    public void BugSpeed(float speedMult) 
    {
        Debug.Log(speedMult);
        for (int i = 0; i < numBugs; i += 1) 
        {
            allBugs[i].GetComponent<flock>().speedMult = speedMult;
        }
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

            //allBugs[i].AddComponent<playAudio>();
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
        
        //allow bugs to follow camera view
        goalPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, cameraDist));
    }
}

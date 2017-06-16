﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalFlock : MonoBehaviour {

	//read in the bug and goal prefabs
	public GameObject bugPrefab;
	public GameObject goalPrefab;

	//instantiating colony box dimensions
	public static int colonySize = 10;

	static int numbugs = 400;

	//instantiating the swarm colony
	public static GameObject[] allBugs = new GameObject[numbugs];

	//instantiating goal position
	public static Vector3 goalPos = Vector3.zero;


    //set bug speedMult to be the slider's multiplier
    public void BugSpeed(float speedMult) 
    {
        Debug.Log(speedMult);
        for (int i = 0; i < numbugs; i += 1) 
        {
            allBugs[i].GetComponent<flock>().speedMult = speedMult;
        }
    }

	// Use this for initialization
	void Start()
	{
		for (int i = 0; i < numbugs; i += 1)
		{
			Vector3 pos = new Vector3(Random.Range(-colonySize, colonySize),
									  Random.Range(-colonySize, colonySize),
									  Random.Range(-colonySize, colonySize));
            allBugs[i] = (GameObject)Instantiate(bugPrefab, pos, Quaternion.identity);
		}
	}

	// Update is called once per frame
	void Update()
	{
        
		//at random timeframes move goal to another location within the colony
		if (Random.Range(0, 10000) < 50)
		{
            /*
			goalPos = new Vector3(Random.Range(-colonySize, colonySize),
									  Random.Range(-colonySize, colonySize),
									  Random.Range(-colonySize, colonySize));
            goalPrefab.transform.position = goalPos;
            */
        }

        //allows bugs to follow user-controlled goal marker
        goalPos = goalPrefab.transform.position;
    }
}

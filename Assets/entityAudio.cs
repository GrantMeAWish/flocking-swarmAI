using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entityAudio : MonoBehaviour {

    public int range;
    public bool played;
    public float timing;
    public int delay = 10;
    private Vector3 pos;
    public float radius;

    // Use this for initialization
    void Start () {
        played = false;
        timing = Time.time;
        pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        playNearbyNeighbors(pos, radius);
	}

    void playNearbyNeighbors(Vector3 center, float radius)
    {
        Collider[] hitColliders = Physics.OverlapSphere(center, radius);
        for (int i = 0;  i < hitColliders.Length; i++)
        {
            AudioSource x = hitColliders[i].GetComponent<AudioSource>();
            x.Play();
        }
    }
}

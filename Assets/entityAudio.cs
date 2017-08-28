using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entityAudio : MonoBehaviour {
<<<<<<< HEAD

=======
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
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
<<<<<<< HEAD
        pos = transform.position;
=======
        pos = transform.position; 
		
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
	}
	
	// Update is called once per frame
	void Update () {
        playNearbyNeighbors(pos, radius);
<<<<<<< HEAD
=======
		
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
	}

    void playNearbyNeighbors(Vector3 center, float radius)
    {
        Collider[] hitColliders = Physics.OverlapSphere(center, radius);
<<<<<<< HEAD
        for (int i = 0;  i < hitColliders.Length; i++)
        {
            AudioSource x = hitColliders[i].GetComponent<AudioSource>();
            x.Play();
=======
        int i = 0;
        while(i < hitColliders.Length)
        {
            AudioSource x = hitColliders[i].GetComponent<AudioSource>();
            x.Play();
            i++; 
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
        }
    }
}

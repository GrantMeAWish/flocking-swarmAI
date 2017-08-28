using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class playAudio : MonoBehaviour {

    new AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
<<<<<<< HEAD
        audio.PlayDelayed(Random.Range(0, 10)); 
        audio.clip = (AudioClip)Resources.Load("Hum15");
        audio.Play();
        audio.loop = true;
        audio.volume = 0.7f;
=======
        audio.clip = (AudioClip)Resources.Load("Hum15");
        audio.Play();
        audio.loop = true;
        audio.volume = 0.001f;
>>>>>>> 33d49564984bcc63b624c06661d0594d0ccb9b56
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}

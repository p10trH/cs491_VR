using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSound : MonoBehaviour {

	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	void OnTriggerEnter(Collider other){

		print("hit");
  		if (!audioSource.isPlaying){
    		audioSource.Play();
  		}
	}
}

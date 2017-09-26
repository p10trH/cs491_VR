using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerLights : MonoBehaviour {

	public GameObject[] lightSources;
	public Renderer rend;
	public bool toggleSwitch = false;

	// Use this for initialization
	void Start () {

		lightSources = GameObject.FindGameObjectsWithTag("roomLight");

		rend = GetComponent<Renderer>();

		rend.material.SetColor("_Color", Color.red);
		rend.material.SetColor("_EmissionColor", Color.red);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){

		print("hit lights");
		
		if (toggleSwitch == true) {

			foreach (GameObject lamp in lightSources)
        	{
            	lamp.GetComponent<Light>().enabled=true;
        	}

			rend.material.SetColor("_Color", Color.red);
			rend.material.SetColor("_EmissionColor", Color.red);

			toggleSwitch = false;
		}
		else if (toggleSwitch == false) {

			foreach (GameObject lamp in lightSources)
        	{
            	lamp.GetComponent<Light>().enabled=false;
        	}

			rend.material.SetColor("_Color", Color.green);
			rend.material.SetColor("_EmissionColor", Color.green);

			toggleSwitch = true;
		}
  		
	}
}

﻿using UnityEngine;
using System.Collections;

public class countDownTimer : MonoBehaviour {
	float timeRemaining = 65;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime;

		if((timeRemaining < 4 && timeRemaining > 3.98f) || (timeRemaining < 3 && timeRemaining > 2.98f) || (timeRemaining < 2 && timeRemaining > 1.98f))
		{
			// GetComponent<AudioSource>().PlayOneShot(countAudio);
		}﻿
	}

	void OnGUI(){
		if (timeRemaining > 0) {
			GUI.Label (new Rect (100, 100, 200, 100), "Time Remaining : " + timeRemaining);
		} else {
			GUI.Label (new Rect (100, 100, 100, 100), "NOOB");
		}
	}
}

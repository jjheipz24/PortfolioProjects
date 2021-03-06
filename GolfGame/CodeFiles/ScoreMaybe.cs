using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ScoreMaybe : MonoBehaviour {

	public bool allowScore = true;
	public bool allowSound = true;
	private AudioSource audioSource;


	// Use this for initialization
	void Awake(){
		audioSource = GetComponent<AudioSource> ();
		DontDestroyOnLoad (this);
	}
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider collider){
		if (allowScore == true && allowSound == true) {
			audioSource.Play ();
			Score.score += 50;
			allowScore = false;
			allowSound = false;
		}
	}

	void OnTriggerExit(Collider collider){
		allowScore = true;
		allowSound = true;
	}


}

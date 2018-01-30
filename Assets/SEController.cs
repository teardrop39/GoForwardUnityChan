using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEController : MonoBehaviour {

	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D(Collision2D obj){

		if(obj.gameObject.tag == "groundTag" || obj.gameObject.tag == "blockTag"){
			audioSource.Play();
		}
	}
}

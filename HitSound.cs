using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSound : MonoBehaviour {

	public AudioClip audioClip;

	private void OnCollisionEnter(Collision other) {
		if(other.relativeVelocity.magnitude>10){
			GetComponent<AudioSource>().PlayOneShot(audioClip);
		}
		
	}
}

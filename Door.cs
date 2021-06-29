using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	public Animator door_animator;
	private void OnTriggerEnter(Collider other) {
		door_animator.SetTrigger("Open");
	}

	private void OnTriggerExit(Collider other) {
		door_animator.SetTrigger("Close");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour {
	
	public GameObject birdPrefab;
	public float speed=15f;
	void Update () {
		if(Input.GetButtonUp("Fire1")){
			// Debug.Log("按下滑鼠左鍵");
			GameObject obj=Instantiate(birdPrefab);
			obj.GetComponent<Rigidbody>().position=transform.position;
			obj.GetComponent<Rigidbody>().velocity=transform.forward*speed;

			Destroy(obj,3f);
		}		
	}
}

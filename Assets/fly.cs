using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour {
	bool isBroomActive;

	// Use this for initialization"
	void Start () {

		isBroomActive = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (GameObject.Find ("Broom") != null) {

			Vector3 direction = Camera.main.transform.forward;
			float scalor = 0.1f + Time.deltaTime;
			transform.Translate (direction * scalor);
			if(GameObject.Find ("hopOn") != null){
				GameObject.Find ("hopOn").SetActive (false);
			}
		}
		//如果broom appear， then move, and set hopOn as false
	}
}

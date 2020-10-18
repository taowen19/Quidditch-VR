using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour {
	float frame = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		if (frame < 200) {
			Vector3 dir = new Vector3 (1.3f, 1.0f, 1.1f);
			float scalor = 0.09f + Time.deltaTime;
			transform.Translate (dir * scalor);

		} else if (200 <= frame && frame < 300) {
			Vector3 dir = new Vector3 (-1.5f, -1.0f, 1.0f);
			float scalor = 0.09f + Time.deltaTime;
			transform.Translate (dir * scalor);

		} else if (300 <= frame && frame < 500) {
			transform.rotation = Quaternion.Euler (0.0f, -90.0f, 0.0f);
			Vector3 dir = new Vector3 (-1.0f, 0.0f, 1.0f);
			float scalor = 0.09f + Time.deltaTime;
			transform.Translate (dir * scalor);
		} else if (500 <= frame && frame < 600) {
			Vector3 dir = new Vector3 (-1.0f, 1.0f, 1.0f);
			float scalor = 0.15f + Time.deltaTime;
			transform.Translate (dir * scalor);
		} else {
		}
			frame = frame + 1;

	}
}

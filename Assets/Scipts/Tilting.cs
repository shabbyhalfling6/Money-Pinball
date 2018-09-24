using UnityEngine;
using System.Collections;

public class Tilting : MonoBehaviour {
	
	private Vector3 originalGravity;

	void Start()
	{
		//save original gravity values
		originalGravity = Physics.gravity;
	}

	void FixedUpdate()
	{
		Physics.gravity = originalGravity;

		if (Input.GetKeyDown ("e")) 
			//add a gravitational force left
			Physics.gravity = new Vector3 (-10, -10, 5);
		else if (Input.GetKeyUp ("o")) 
			//add a gravitational force right
			Physics.gravity = new Vector3 (10, -10, 5);
	}
}

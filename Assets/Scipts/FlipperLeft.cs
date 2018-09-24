using UnityEngine;
using System.Collections;

public class FlipperLeft : MonoBehaviour {
	

	void Update()
	{
		if (Input.GetKeyDown ("f"))
			transform.Rotate (0, -40, 0 * Time.deltaTime);
	
		if (Input.GetKeyUp ("f"))
			transform.rotation = Quaternion.identity;
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Ball" && Input.GetKeyDown ("f"))
		{
			col.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,-1000,0);
			Debug.Log("TEST");
		}
	}
}

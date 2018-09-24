using UnityEngine;
using System.Collections;

public class FlipperRight : MonoBehaviour {

	void Update()
	{
		if (Input.GetKeyDown ("j"))
			transform.Rotate (0, 40, 0 * Time.deltaTime);
		
		if (Input.GetKeyUp ("j"))
			transform.rotation = Quaternion.identity;
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Ball" && Input.GetKeyDown ("j"))
		{
			col.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,-1000,0);
			Debug.Log("TEST");
		}
	}
}

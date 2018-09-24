using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	private AudioSource springLaunch;

	public float launchSpeed = 6000f;
	//private float pressTime = 0f;
	//private float maxTimePress = 4f;

	void Start()
	{
		springLaunch = this.GetComponent<AudioSource> ();
	}

	void Update()
	{
		this.GetComponent<BoxCollider> ().enabled = false;
		if (Input.GetKeyDown ("space"))
			this.GetComponent<BoxCollider>().enabled = true;
	}

	void OnTriggerEnter(Collider col) 
	{
		if (col.gameObject.tag == "Ball" /*&& Input.GetKeyDown ("space")*/) 
		{
			springLaunch.Play ();
			col.gameObject.GetComponent<Rigidbody>().AddForce (transform.forward * launchSpeed);
		}

			/*if (Input.GetKeyDown ("space"))
			pressTime = Time.time;

		if (Input.GetKeyUp ("space") || pressTime >= maxTimePress)
		{
			Debug.Log(pressTime);
			this.GetComponent<Rigidbody>().AddForce (transform.forward * pressTime * launchSpeed);
			pressTime = 0f;
		}*/
	}
}

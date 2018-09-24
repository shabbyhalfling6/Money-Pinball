using UnityEngine;
using System.Collections;

public class Deadzone : MonoBehaviour {

	public GameContoller gameController;

	private Vector3 ballSpawnPosition;
	private Quaternion ballSpawnRotation; 

	void Start()
	{
		//save the original rotation and position of the ball to set a spawn point
		ballSpawnPosition = GameObject.FindGameObjectWithTag ("Ball").transform.position;
		ballSpawnRotation = GameObject.FindGameObjectWithTag ("Ball").transform.rotation;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Ball") 
		{
			//destoy the ball if it reaches the deadzone and spawn a new ball at the spawn position
			Destroy (col.gameObject);
			gameController.DeductALife();
			Instantiate (col.gameObject, ballSpawnPosition, ballSpawnRotation);
		}
	}
}

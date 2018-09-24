using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

	public AudioSource bumperAudio;
	public GameContoller gameController;

	public int reward = 100;

	void Start()
	{
		bumperAudio = this.GetComponent<AudioSource> ();
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Ball")
		{
			bumperAudio.Play ();
			gameController.AddScore(reward);
		}
	}

}

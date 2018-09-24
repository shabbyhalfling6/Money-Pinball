using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LivesCounter : MonoBehaviour {
	
	public Text value;

	public void Start()
	{
		value = this.gameObject.GetComponent<Text> ();
	}

	public void SetLives (int lives)
	{
		value.text = "LIVES: " + lives.ToString ();
	}
}

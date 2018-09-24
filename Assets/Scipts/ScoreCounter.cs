using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

	public Text value;

	void Start()
	{
		value = this.gameObject.GetComponent<Text> ();
	}

	public void SetScore(int currentScore)
	{
		value.text = "BALANCE: $" + currentScore.ToString();
	}
}

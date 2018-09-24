using UnityEngine;
using System.Collections;

public class GameContoller : MonoBehaviour {

	public GameObject pauseMenu;
	public GameObject gameOverMenu;
	public GameObject livesCounter;
	public GameObject scoreCounter;

	private int lives = 3;
	public int score = 0;

	void Start()
	{
		Time.timeScale = 1.0f;
	}

	void Update ()
	{
		Pause ();

		//tests if the game is over
		if (lives == 0)
		{
			//set the gameover menu to be active in the scene and stop gameplay
			gameOverMenu.SetActive(true);
			Time.timeScale = 0.0f;
		}
	}

	void Pause()
	{
		if (Input.GetKeyDown ("escape"))
		{
			//pause toggling 
			if (Time.timeScale == 0.0f)
			{
				//set the pause text to be not active in the scene when the game is unpaused and set the time back to normal
				pauseMenu.SetActive(false);
				Time.timeScale = 1.0f;
			}
			else
			{
				//set the pause text to be active in the scene when the game is paused and set the time back to normal
				pauseMenu.SetActive(true);
				Time.timeScale = 0.0f;
			}
		}
	}

	public void DeductALife()
	{
		//decrement lives
		lives--;
		//set HUD livescounter to the new value
		livesCounter.GetComponent<LivesCounter> ().SetLives(lives);
	}

	public void AddScore(int value)
	{
		//add the score reward to the total score
		score += value;
		//set HUD scorecounter to the new value
		scoreCounter.GetComponent<ScoreCounter> ().SetScore (score);
	}
}

using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public void OnClickReload()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	public void OnClickLoad()
	{
		Application.LoadLevel ("MainMenu");
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuLoad : MonoBehaviour {		
	public GameObject menu;
	public GameObject score;
	
	public void LoadMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void SwitchCameraViewToScoreboard(){
		menu.SetActive (false);
		score.SetActive (true);
	}

	public void SwitchCameraViewToMainMenu(){
		if (score.gameObject.activeSelf) {
			GameObject[] scores = GameObject.FindGameObjectsWithTag ("Scoreboard");
			foreach (GameObject sc in scores)
				GameObject.Destroy (sc);
		}

		
		score.SetActive (false);
		menu.SetActive (true);
	}

	public void LoadSingleplayer(){
		SceneManager.LoadScene ("Singleplayer");
	}

	public void LoadMultiplayer(){
		SceneManager.LoadScene ("Multiplayer");
	}

	public void Logout(){
		SceneManager.LoadScene ("Login");
	}
}

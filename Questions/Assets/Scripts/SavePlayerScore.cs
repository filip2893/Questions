using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SavePlayerScore : MonoBehaviour {
	private string postDataURL = "http://127.0.0.1/pgsql/sendScore.php";
	public static bool posaljiRezultat = false; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (posaljiRezultat) {
			StartCoroutine(PostData());
			SceneManager.LoadScene ("MainMenu");
			Player.bodovi = 0;
			posaljiRezultat = false;
		}
	}

	IEnumerator PostData(){		

		WWWForm forma = new WWWForm ();
		forma.AddField ("id", Player.korisnikID);
		forma.AddField ("bodovi", Player.bodovi);		

		WWW data_post = new WWW(postDataURL,forma);
		Debug.Log (Player.korisnikID);
		Debug.Log (Player.bodovi);
		yield return data_post; 

		if (data_post.error != null){
			print("There was an error saving data: " + data_post.error);
		}
	}

	void OnTriggerEnter2D(){		
		posaljiRezultat = true;
	}
}

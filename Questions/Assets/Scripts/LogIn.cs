using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class LogIn : MonoBehaviour {
	public InputField korime;
	public InputField lozinka;
	public string postDataURL = "http://localhost/pgsql/getUserData.php";
	public static bool klik = false;

	//public Text kriviUnos;
	// Use this for initialization
	void Start () {
		//kriviUnos.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (klik) {
			StartCoroutine(PostData());
			klik = false;
		}
	}

	public void PrijavaGumb(){
		klik = true;
	}
	IEnumerator PostData(){
		string korisnickoIme = korime.text;
		string Lozinka = lozinka.text;
		WWWForm forma = new WWWForm ();
		forma.AddField ("korime", korisnickoIme);
		forma.AddField ("loz", Lozinka);		

		WWW data_post = new WWW(postDataURL,forma);
		yield return data_post; 

		if (data_post.error != null){
			print("There was an error saving data: " + data_post.error);
		}

		string podaci = data_post.text;

		if (podaci != "-1") {
			SceneManager.LoadScene ("MainMenu");
			Player.korisnikID = Int32.Parse (podaci);
			//kriviUnos.enabled = false;
		} else
			Debug.Log("nema");
			//kriviUnos.enabled = true;
	}
}

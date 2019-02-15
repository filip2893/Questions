using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class LoadScores : MonoBehaviour {
	private string receiveDataURL = "http://127.0.0.1/pgsql/getUserScore.php";
	private bool active = false;
	public GameObject scores;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (active) {
			StartCoroutine (getScores());
			active = false;
		}
	}

	IEnumerator getScores(){

		WWW data_receive = new WWW (receiveDataURL);
		yield return data_receive;
		string podaci = data_receive.text;
		string[] items = Regex.Split(podaci, "<br>");

		//Text child = scores.GetComponentInChildren<Text>();
		//child.text = items [0];

		Vector3 poz = GameObject.FindGameObjectWithTag ("Header").transform.position;

		for (int i = 0; i < items.Length-1; i=i+3) {			
			GameObject go = (GameObject)Instantiate (scores);

			poz.y -= 30;

			go.transform.SetParent (this.transform);
			go.transform.position = poz;
			go.transform.Find ("player").GetComponent<Text> ().text = items [i];
			go.transform.Find ("score").GetComponent<Text> ().text = items [i+1];
			go.transform.Find ("date").GetComponent<Text> ().text = items [i+2];
			Debug.Log (i);
		}
	}

	public void setActiveScores(){
		active = true;
	}
}

using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class ActivateQuest : Photon.MonoBehaviour {		
	//GameObject myQuestion;
	public int id;
	public Transform questions;
	bool getQuestion = false, buttonClicked = false;

	private string receiveDataURL = "http://127.0.0.1/pgsql/getQuestionAndAnswers.php";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (getQuestion) {
			StartCoroutine (GetQuestionAndAnswers());
			getQuestion = false;
		}
		if (buttonClicked) {
			StartCoroutine (ButtonClicked());
			buttonClicked = false;
		}
	}
	IEnumerator GetQuestionAndAnswers(){
		WWWForm forma = new WWWForm();

		forma.AddField ("id",id);

		WWW data_receive = new WWW (receiveDataURL,forma);
		yield return data_receive;
		string podaci = data_receive.text;
		string[] items = Regex.Split(podaci, "<br>");

		Text childQuestion = questions.GetComponentInChildren<Text>();
		childQuestion.text = items [0];

		Button[] Buttons = questions.GetComponentsInChildren<Button> ();


		for (int i = 0; i < 4; i++) {			
			Text childAnswers = Buttons [i].GetComponentInChildren<Text> ();
			childAnswers.text = items [i+1];
			if (items [i + 5].Equals ("t")) {
				CorrectAnswerChecker.TocanOdgovor = items [i + 1];
			}				
		}
	}

	IEnumerator ButtonClicked(){
		yield return new WaitForSeconds (1);
		getQuestion = false;
		questions.gameObject.SetActive (false);
	}

	void OnTriggerEnter2D(){
		getQuestion = true;
		questions.gameObject.SetActive (true);
	}
	void OnTriggerExit2D(){
		questions.gameObject.SetActive (false);
	}
	public void closeQuestion(){		
		buttonClicked = true;
	}
}

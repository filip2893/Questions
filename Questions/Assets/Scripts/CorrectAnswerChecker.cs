using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CorrectAnswerChecker : MonoBehaviour {
	public static string TocanOdgovor;
	public Text bodoviText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void checkAnswer(){
		Text childAnswers =	this.GetComponentInChildren<Text> ();
		if (childAnswers.text.Equals(TocanOdgovor)) {
			updateScore ();
			//PlayerGold.playerGold += 10;
		} 
	}

	public void updateScore(){
		Player.bodovi += 10;
		bodoviText.text = "Bodovi: " + Player.bodovi;
	}
}

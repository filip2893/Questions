using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MultiplayerQuest : MonoBehaviour {
	// Use this for initialization
	int bodovi;
	int playerWhoIs;
	bool guiEnabled = false;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(){
		PhotonView pv = PhotonView.Get (this);
		if (pv.isMine) {	
			PhotonNetwork.player.AddScore (10);
			//pv.RPC ("AddScore", PhotonTargets.AllBuffered);
			//AddScore ();
		}
		guiEnabled = true;
	}
	void OnTriggerExit2D(){
		guiEnabled = false;	
	}

	public void OnGUI(){
		if (guiEnabled) {
			

			//playerWhoIs = PhotonNetwork.player.ID;

			GUI.Label (new Rect (16, 16, 128, 24), "Score:  " + PhotonNetwork.player.GetScore());

				//AddScore ();

			//Destroy (this);
		}
	
	}



}

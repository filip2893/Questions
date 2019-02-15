using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {
	public Camera StandByCamera;
	SpawnSpot[] spawnSpots;

	// Use this for initialization
	void Start () {
		spawnSpots = GameObject.FindObjectsOfType<SpawnSpot> ();
		Connect ();
	}
	
	void Connect(){
		PhotonNetwork.ConnectUsingSettings ("1.0.0");
	}

	void OnGUI(){
		GUILayout.Label (PhotonNetwork.connectionStateDetailed.ToString ());
	}

	void OnJoinedLobby(){
		Debug.Log ("nije spojeno");
		PhotonNetwork.JoinRandomRoom ();
	}

	void OnPhotonRandomJoinFailed(){
		Debug.Log ("OnPhotonRandomJoinFailed");
		PhotonNetwork.CreateRoom (null);
	}

	void OnJoinedRoom(){
		Debug.Log ("OnJoinedRoom");
		SpawnMyPlayer ();
	}

	void SpawnMyPlayer(){
		if (spawnSpots == null) {
			Debug.LogError ("WTF");
			return;
		}
		SpawnSpot mySpawnSpot = spawnSpots [Random.Range (0, spawnSpots.Length)];
		GameObject myPlayerGO = (GameObject)PhotonNetwork.Instantiate ("Player",mySpawnSpot.transform.position, mySpawnSpot.transform.rotation, 0);

		//GameObject score = (GameObject)PhotonNetwork.Instantiate ("Score",mySpawnSpot.transform.position, mySpawnSpot.transform.rotation, 0);

		StandByCamera.enabled = false;
		myPlayerGO.GetComponent<PlayerMovement> ().enabled = true;
		//myPlayerGO.GetComponent<SpriteRenderer> ().enabled = true;
		myPlayerGO.transform.FindChild ("Main Camera").gameObject.SetActive (true);
		//myPlayerGO.transform.FindChild ("Score").gameObject.SetActive (true);
		int playerWhoIs = PhotonNetwork.player.ID;
		Player.playerScore[PhotonNetwork.player.ID] = 0;
	}
}

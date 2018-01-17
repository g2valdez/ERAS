using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EraNetworkManager : NetworkManager {
	public gamestate gameState;
	public GameObject[] playerPrefabs = new GameObject[2];
	private GameObject[] players = new GameObject[2];
	private short[] playerIDs = new short[2];
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId) {
		print(playerControllerId);
		if (players[0] == null) {
			var player = (GameObject)GameObject.Instantiate(playerPrefabs[0], Vector3.zero, Quaternion.identity);
			players[0] = player;
			NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);

		}
		else if (players[1] == null) {
			var player = (GameObject)GameObject.Instantiate(playerPrefabs[1], Vector3.zero, Quaternion.identity);
			players[1] = player;
			playerIDs[1] = playerControllerId;
			NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);

			for (int i = 0; i < players.Length; i++) {
				gameState.addPlayer(players[i], i);
			}

		}


	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EraNetworkManager : NetworkManager {
	public GameObject[] playerPrefabs = new GameObject[2];
	private GameObject[] players = new GameObject[2];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId) {
		print(playerControllerId);
		if (players[0] == null) {
			var player = (GameObject)GameObject.Instantiate(playerPrefabs[0], new Vector3(-20.0f, -20.0f, 0.0f), Quaternion.identity);
			players[0] = player;
			NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);

		}
		else if (players[1] == null) {
			var player = (GameObject)GameObject.Instantiate(playerPrefabs[1], new Vector3(-20.0f, 20.0f, 0.0f), Quaternion.identity);
			players[1] = player;
			NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);

			// for (int i = 0; i < players.Length; i++) {
			// 	gameState.addPlayer(players[i], i);
			// }

		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamestate : MonoBehaviour {
	private GameObject player;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void addPlayer(GameObject newPlayer, int startEra) {
		player = newPlayer;
		player.transform.position = new Vector3(0,0,-0.1f);
	}
}

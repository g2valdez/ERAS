using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class gamestate : MonoBehaviour {
	public GameObject[] eras = new GameObject[3];
	private GameObject player;
	private int era;

	// Use this for initialization
	void Start () {
		era = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			era = 0;
			player.transform.SetParent(eras[0].transform, false);
		}
    	if (Input.GetKeyDown(KeyCode.Alpha2)) {
			era = 1;
    		player.transform.SetParent(eras[1].transform, false);
    	}
    	if (Input.GetKeyDown(KeyCode.Alpha3)) {
			era = 2;
    		player.transform.SetParent(eras[2].transform, false);
    	}
    	var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        eras[era].transform.position += new Vector3(x, z, 0);
	}

	public void addPlayer(GameObject newPlayer, int startEra) {
		player = newPlayer;
		era = startEra;
		player.transform.position = new Vector3(0,0,-0.1f);
		player.transform.SetParent(eras[era].transform, false);
	}
}

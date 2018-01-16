using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class gamestate : MonoBehaviour {
	public GameObject[] eras = new GameObject[3];
	public GameObject player;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1)) player.transform.SetParent(eras[0].transform, false);
    	if (Input.GetKeyDown(KeyCode.Alpha2)) player.transform.SetParent(eras[1].transform, false);
    	if (Input.GetKeyDown(KeyCode.Alpha3)) player.transform.SetParent(eras[2].transform, false);

    	var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        eras[0].transform.position += new Vector3(x, z, 0);
        eras[1].transform.position += new Vector3(x, z, 0);
        eras[2].transform.position += new Vector3(x, z, 0);

    	// eras[1].position += new Vector3(x, z, 0.0f);

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class PlayerController : NetworkBehaviour {
	private GameObject[] eraCams = new GameObject[3];
	private Vector3 truePosition = new Vector3(0,0,-0.1f);
	private Vector3[] displacements = new Vector3[3];
	private int era;
	
	// Use this for initialization
	void Start () {
		eraCams[0] = GameObject.Find("birthCam");
		eraCams[1] = GameObject.Find("lifeCam");
		eraCams[2] = GameObject.Find("deathCam");
		era = 1;

		displacements[0] = new Vector3(-20.0f, -20.0f, 0);
		displacements[1] = new Vector3(-20.0f, 20.0f, 0);
		displacements[2] = new Vector3(20.0f, 20.0f, 0);
		// transform.SetParent(eras[era].transform, false);

	}
	
	// Update is called once per frame
	void Update()
    {
    	if (!isLocalPlayer) return;

    	if (Input.GetKeyDown(KeyCode.Alpha1)) {
			era = 0;
			// transform.SetParent(eras[0].transform, false);
		}
    	if (Input.GetKeyDown(KeyCode.Alpha2)) {
			era = 1;
    		// transform.SetParent(eras[1].transform, false);
    	}
    	if (Input.GetKeyDown(KeyCode.Alpha3)) {
			era = 2;
    		// transform.SetParent(eras[2].transform, false);
    	}

    	var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        truePosition += new Vector3(x, z, 0);
        // var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        // var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        transform.position = truePosition + displacements[era];

        // Vector3 tempLocation = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
        // if (tempLocation.x > 3.75f) tempLocation.x = 3.75f;
        // if (tempLocation.x < -3.75f) tempLocation.x = -3.75f;
        // if (tempLocation.y > 4.75f) tempLocation.y = 4.75f;
        // if (tempLocation.y < -4.75f) tempLocation.y = -4.75f;
        // transform.localPosition = tempLocation;
    }
}

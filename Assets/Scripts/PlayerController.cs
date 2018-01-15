using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Vector3 absolutePosition = new Vector3(0,0,0);
	public Vector3[] displacements = new Vector3[3];
	private int era = 1;
	private float xBound = 2.5f;
	private float yBound = 1.3f;
	// Use this for initialization
	void Start () {
		displacements[0] = new Vector3(-5.9f, 0.0f, 0.0f);
		displacements[1] = new Vector3(0.0f, 0.0f, 0.0f);
		displacements[2] = new Vector3(5.9f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update()
    {
    	if (Input.GetKeyDown(KeyCode.Alpha1)) era = 0;
    	if (Input.GetKeyDown(KeyCode.Alpha2)) era = 1;
    	if (Input.GetKeyDown(KeyCode.Alpha3)) era = 2;

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        absolutePosition += new Vector3(x, z, 0);

        //check boundaries
        // print(absolutePosition);
        if (absolutePosition.x > xBound) absolutePosition.x = xBound;
        if (absolutePosition.x < -xBound) absolutePosition.x = -xBound;
        if (absolutePosition.y > 4.6f) absolutePosition.y = 4.6f;
        if (absolutePosition.y < -yBound) absolutePosition.y = -yBound;

        transform.position = absolutePosition + displacements[era];

    }
}

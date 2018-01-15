using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class gamestate : MonoBehaviour {

	public Tilemap tilemap;
	public Tile defaultTile;

	// Use this for initialization
	void Start () {
		// tilemap.BoxFill(Vector3Int.zero,defaultTile, 0, 0, 100, 100);
		tilemap.SetTile(new Vector3Int(0,4,0), defaultTile);
		tilemap.SetTile(new Vector3Int(8,0,0), defaultTile);
		tilemap.SetTile(new Vector3Int(0,-5,0), defaultTile);
		tilemap.SetTile(new Vector3Int(-9,0,0), defaultTile);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

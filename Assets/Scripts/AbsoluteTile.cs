using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

// public class AbsoluteTile : MonoBehaviour {
// 	public Tile birthTile;
// 	public Tile lifeTile;
// 	public Tile deathTile;

// 	// Use this for initialization
// 	void Start () {

// 	}
	
// 	// Update is called once per frame
// 	void Update () {
		
// 	}
// }

public class AbsoluteTile {
	public Tile[] tileAssets;

	// Use this for initialization
	public AbsoluteTile(Tile[] theTiles) {
		tileAssets = theTiles;
	} 

}
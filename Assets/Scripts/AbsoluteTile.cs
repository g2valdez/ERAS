using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class AbsoluteTile {
	public Tile[] tileAssets;

	// takes in an array of 3 tiles, one for each era
	public AbsoluteTile(Tile[] theTiles) {
		tileAssets = theTiles;
	}

}
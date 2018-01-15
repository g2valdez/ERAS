using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class gamestate : MonoBehaviour {

	public Tilemap tilemap;
	public Tile[] tileAssets = new Tile[3];

	private AbsoluteTile[,] absTileStage = new AbsoluteTile[7,8];


	// Use this for initialization
	void Start () {

		for (int j = 0; j < 7; j++) {
			for (int k = 0; k < 8; k++) {
				absTileStage[j,k] = new AbsoluteTile(tileAssets);
			}
		}

		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 7; j++) {
				for (int k = 0; k < 8; k++) {
					tilemap.SetTile(new Vector3Int(j-11+(i*7),k-2,0), absTileStage[j,k].tileAssets[i]);
				}
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

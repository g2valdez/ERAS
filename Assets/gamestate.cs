using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class gamestate : MonoBehaviour {

	public Tilemap tilemap;
	public Tile[] tileAssets = new Tile[3];

	private AbsoluteTile[,] absTileStage = new AbsoluteTile[6,6];


	// Use this for initialization
	void Start () {

		for (int j = 0; j < 6; j++) {
			for (int k = 0; k < 6; k++) {
				absTileStage[j,k] = new AbsoluteTile(tileAssets);
			}
		}

		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 6; j++) {
				for (int k = 0; k < 6; k++) {
					tilemap.SetTile(new Vector3Int(j-9+(i*6),k-1,0), absTileStage[j,k].tileAssets[i]);
				}
			}
		}

		tilemap.SetTile(new Vector3Int(0,4,0), tileAssets[1]);
		tilemap.SetTile(new Vector3Int(8,0,0), tileAssets[1]);
		tilemap.SetTile(new Vector3Int(0,-5,0), tileAssets[1]);
		tilemap.SetTile(new Vector3Int(-9,0,0), tileAssets[1]);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

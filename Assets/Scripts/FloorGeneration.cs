using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorGeneration : MonoBehaviour {

    private Tile[,] tiles;
    public int boardHeight = 10;
    public int boardWidth = 10;
    public GameObject prefab; 
    public int count = 0;

	// Use this for initialization
	void Start () {
        tiles = new Tile[boardHeight, boardWidth];

        for (int col = 0; col < boardWidth; ++col)
        {
            for (int row = 0; row < boardHeight; ++row)
            {
                //Tile tile = Utilities.GetNewCell();
                float x = col;
                float z = row;

                GameObject go = (GameObject)GameObject.Instantiate(prefab, Vector3.zero, Quaternion.identity);
                go.transform.localPosition = new Vector3(x, 0f, z);

                Tile tile = go.GetComponent<Tile>();

                tiles[col, row] = tile;
            }
        }
    }
}
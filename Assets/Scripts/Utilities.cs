using UnityEngine;
using System.Collections;

public class Utilities : object {

	public static Tile GetNewCell() {

		GameObject prefab = Resources.Load<GameObject>("Tile");
		GameObject go = (GameObject)GameObject.Instantiate(prefab,Vector3.zero,Quaternion.identity);
		go.name = prefab.name;

		Transform grid = GameObject.FindGameObjectWithTag("FloorGeneration").transform;
		go.transform.SetParent(grid);

		Tile cell = go.GetComponent<Tile>();

		return cell;
	}

	public static void ChangeCellColor(Tile cell, Color color) {

		MeshRenderer mr = cell.gameObject.GetComponent<MeshRenderer>();
        if (mr)
        {
            Material materialCopy = (Material)GameObject.Instantiate(mr.sharedMaterial);
            materialCopy.color = color;
            mr.material = materialCopy;
        }
	}
}

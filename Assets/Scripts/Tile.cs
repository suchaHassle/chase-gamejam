
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.localScale = Vector3.one;
        setColor(Color.gray);
    }

    public void setColor(Color color)
    {
        MeshRenderer mr = this.gameObject.GetComponent<MeshRenderer>();
        if (mr)
        {
            Material materialCopy = (Material)GameObject.Instantiate(mr.sharedMaterial);
            materialCopy.color = color;
            mr.material = materialCopy;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player"))
        {
            MeshRenderer mr = this.gameObject.GetComponent<MeshRenderer>();

            if (mr)
            {
                Material materialCopy = (Material)GameObject.Instantiate(mr.sharedMaterial);
                if (materialCopy.color != Color.blue)
                    GameObject.Find("Tile").GetComponent<FloorGeneration>().count++;
            }

            setColor(Color.blue);
        }
    }
}

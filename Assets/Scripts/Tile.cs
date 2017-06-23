
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
                if (materialCopy.color == Color.gray)
                    GameObject.Find("Tile").GetComponent<FloorGeneration>().count++;
            }

            int caseSwitch = GameObject.Find("Tile").GetComponent<FloorGeneration>().caseSwitch; 
            switch (caseSwitch)
            {
                case 1:
                    {
                        setColor(new Color(255f/255f, 35f/255f, 33f/255f)); // red
                        GameObject.Find("Tile").GetComponent<FloorGeneration>().caseSwitch++;
                        break;
                    }
                case 2:
                    {
                        setColor(new Color(250f / 255f, 126f / 255f, 13f / 255f)); //orange
                        GameObject.Find("Tile").GetComponent<FloorGeneration>().caseSwitch++;
                        break;
                    }
                case 3:
                    {
                        setColor(new Color(240f / 255f, 225f / 255f, 46f / 255f)); // yellow
                        GameObject.Find("Tile").GetComponent<FloorGeneration>().caseSwitch++;
                        break;
                    }
                case 4:
                    {
                        setColor(new Color(93f / 255f, 250f / 255f, 3f / 255f)); // green
                        GameObject.Find("Tile").GetComponent<FloorGeneration>().caseSwitch++;
                        break;
                    }
                case 5:
                    {
                        setColor(new Color(86f / 255f, 214f / 255f, 247f / 255f)); // cyan
                        GameObject.Find("Tile").GetComponent<FloorGeneration>().caseSwitch++;
                        break;
                    }
                case 6:
                    {
                        setColor(Color.blue); //blue
                        GameObject.Find("Tile").GetComponent<FloorGeneration>().caseSwitch = 1;
                        break;
                    }
                
             



            }
            
        }
    }
}

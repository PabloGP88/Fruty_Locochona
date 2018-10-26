using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDoor : MonoBehaviour {
    Color[] colors; // 0 Rojo, 1 verde
    Color color;
    bool enable;
    Collider2D col;
	// Use this for initialization
	void Start () {
        colors = DoorScript.FindObjectOfType<DoorScript>().colors;
        color = gameObject.GetComponent<SpriteRenderer>().color;
	}
	
	// Update is called once per frame
	void Update () {
		if (color == colors[0])
        {

        }
	}
}

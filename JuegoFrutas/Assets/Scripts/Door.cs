﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    Color[] colors; // 0 Rojo, 1 verde
    Color color;
    BoxCollider2D col;

	// Use this for initialization
	void Start () {
        colors = DoorScript.FindObjectOfType<DoorScript>().colors;
        color = gameObject.GetComponent<SpriteRenderer>().color;
        col = gameObject.GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
    }



}

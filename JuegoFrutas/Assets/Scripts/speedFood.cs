﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedFood : MonoBehaviour {

    Rigidbody2D rb2d;

    public float sx;

    bool inverse;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sx = 3;

    }


    private void Update()
    {
        
        rb2d.velocity = new Vector2(sx, 0);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "spawnRight")
        {
            sx *= -1;

        }
    }

  

}

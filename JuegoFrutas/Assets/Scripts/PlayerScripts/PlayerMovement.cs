﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    void Update()
    {
        if (transform.position.x <= 8 || transform.position.x >= -8)
        {
            float translation = Input.GetAxis("Horizontal") * speed;
            translation *= Time.deltaTime;
            transform.Translate(translation, 0, 0);
        }
    }

    void Limites(){

        }
}
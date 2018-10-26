using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFall : MonoBehaviour {
    public float fallSpeed;

    private void Update()
    {
        gameObject.transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
    }
}

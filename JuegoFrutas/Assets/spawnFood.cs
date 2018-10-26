using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFood : MonoBehaviour {


    public GameObject[] food;

    int[] spawnValues = new int[] { 400,500,300};

    int contador;

    // -----------------------------------------------------
    void Start()
    {



    }

    void Update()
    {
        contador++;
        if (contador >= spawnValues[Random.Range(0, spawnValues.Length)])
        {
            Instantiate(food[Random.Range(0, food.Length)], transform.position, Quaternion.identity);
            contador = 0;
        }
    }




}

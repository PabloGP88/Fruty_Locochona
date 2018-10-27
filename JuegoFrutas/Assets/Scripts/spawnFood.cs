using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFood : MonoBehaviour {


    public GameObject[] food;
    float tiempo1 = 300;
    


    int contador;

    // -----------------------------------------------------
    void Start()
    {



    }

    void Update()
    {

        contador++;
        if (tiempo1 > 100)
        {
            tiempo1 -= 2f * Time.deltaTime;
        }
        if (contador >= tiempo1)
        {
            Instantiate(food[Random.Range(0, food.Length)], transform.position, Quaternion.identity);
            contador = 0;

        }
    }




}

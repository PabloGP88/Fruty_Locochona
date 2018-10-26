using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour {



    public GameObject[] food;

    int contador;

    // -----------------------------------------------------
    void Start() {

        

    }
	
	void Update () {
        contador++;
        if(contador >= 100) 
        {
            Instantiate(food[Random.Range(0, food.Length)],transform.position, Quaternion.identity);
            contador = 0;
        }
	}


}

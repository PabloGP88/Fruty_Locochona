using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointSystem : MonoBehaviour {

    public int points;

   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Healthy")
        {
            points += 1;
        }

        if (col.gameObject.tag == "Chatarra")
        {
            lifeStats.FindObjectOfType<lifeStats>().vida -= 1; 
        }

        // Aumenta StatsPlayer
         lifeStats.FindObjectOfType<lifeStats>().calorias += col.gameObject.GetComponent<FoodStat>().calorias; // Calorias
         lifeStats.FindObjectOfType<lifeStats>().azucar += col.gameObject.GetComponent<FoodStat>().azucar; // Azucar
         lifeStats.FindObjectOfType<lifeStats>().grasa += col.gameObject.GetComponent<FoodStat>().grasa; // Grasa
         Destroy(col.gameObject);
    }

}

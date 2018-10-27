using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    bool cambia = false;
    public int restaCalorias;
    public int restaGrasa;
    public int restaStamina;
    public ParticleSystem particulaPesa;
    public GameObject particulaSpawn;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left") && cambia == false && lifeStats.FindObjectOfType<lifeStats>().calorias >0 && lifeStats.FindObjectOfType<lifeStats>().grasa >0 && lifeStats.FindObjectOfType<lifeStats>().stamina >= 10)
        {
            Debug.Log("Left Arrow");
            cambia = true;

            RestarStats();
            
        }

        if (Input.GetKeyDown("right")&& cambia == true && lifeStats.FindObjectOfType<lifeStats>().calorias > 0 && lifeStats.FindObjectOfType<lifeStats>().grasa > 0 && lifeStats.FindObjectOfType<lifeStats>().stamina >= 10)
        {
            Debug.Log("Right Arrow");
            Instantiate(particulaPesa, particulaSpawn.transform.position, Quaternion.identity);
            cambia = false;
            RestarStats();
            
        }


    }
    void RestarStats() {
        lifeStats.FindObjectOfType<lifeStats>().calorias -= restaCalorias;// Calorias
        lifeStats.FindObjectOfType<lifeStats>().grasa -= restaGrasa;// Grasa
        lifeStats.FindObjectOfType<lifeStats>().stamina -= restaStamina;
    }
}

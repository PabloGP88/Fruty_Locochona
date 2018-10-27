using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointSystem : MonoBehaviour {

    public int points;

    [SerializeField] AudioClip[] effects;

    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Healthy")
        {
            AudioClip clip = effects[(int)Random.Range(1,effects.Length)];
            audioSource.PlayOneShot(clip);
            points += 1;
        }

        if (col.gameObject.tag == "Chatarra")
        {
            AudioClip clip = effects[0];
            audioSource.PlayOneShot(clip);
            lifeStats.FindObjectOfType<lifeStats>().vida -= 1; 
        }

        // Aumenta StatsPlayer
         lifeStats.FindObjectOfType<lifeStats>().calorias += col.gameObject.GetComponent<FoodStat>().calorias; // Calorias
         lifeStats.FindObjectOfType<lifeStats>().azucar += col.gameObject.GetComponent<FoodStat>().azucar; // Azucar
         lifeStats.FindObjectOfType<lifeStats>().grasa += col.gameObject.GetComponent<FoodStat>().grasa; // Grasa
         lifeStats.FindObjectOfType<lifeStats>().stamina += col.gameObject.GetComponent<FoodStat>().stamina; // Grasa
        Destroy(col.gameObject);
    }

}

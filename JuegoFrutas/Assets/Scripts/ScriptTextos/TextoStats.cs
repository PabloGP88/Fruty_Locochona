using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextoStats : MonoBehaviour {
    public Text azucar;
    public Text grasa;
    public Text calorias;
    public Text stamina;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        azucar.text = lifeStats.FindObjectOfType<lifeStats>().azucar.ToString();
        grasa.text = lifeStats.FindObjectOfType<lifeStats>().grasa.ToString();
        calorias.text = lifeStats.FindObjectOfType<lifeStats>().calorias.ToString();
        stamina.text = lifeStats.FindObjectOfType<lifeStats>().stamina.ToString();
    }
}

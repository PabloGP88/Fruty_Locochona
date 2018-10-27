using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeStats : MonoBehaviour {

    public int vida;
    public int azucar;
    public int grasa;
    public int calorias;
    public int stamina;
    public bool Colesterol;
    public bool Diabetes;
    public bool Obesidad;

	// Use this for initialization
	void Start () {
        vida = 100;
        stamina = 100;
	}
	
	// Update is called once per frame
	void Update () {
        limiteCantidad();
        stamina += (int)(1 * Time.deltaTime);
    }

    void limiteCantidad()
    {

        if (azucar <= 0)
        {
            azucar = 0;
        }
        if (grasa <= 0)
        {
            grasa = 0;
        }
        if (calorias <= 0)
        {
            calorias = 0;
        }
    }
}

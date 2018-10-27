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
        StartCoroutine(AumentarStamina());
	}
	
	// Update is called once per frame
	void Update () {
        limiteCantidad();
            }

    IEnumerator AumentarStamina() {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            stamina += 1;
        }
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
        if (stamina <= 0){
            stamina = 0;
        }else if (stamina >= 100)
        {
            stamina = 100;
        }

    }
}

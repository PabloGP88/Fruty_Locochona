using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class lifeStats : MonoBehaviour {

    public int vida;
    public int azucar;
    public int grasa;
    public int calorias;
    public int stamina;


    [Header("Enfermedades")]
    public int grasaMax;
    public int azucarMax;
    public int caloriasMax;
    public bool colesterol;
    public bool diabetes;
    public bool obesidad;
    [Header ("Textos")]
    // Textos
    public Text colesterolText;
    public Text diabetesText;
    public Text obesidadText;

    // Use this for initialization
    void Start () {
        vida = 100;
        stamina = 100;
        StartCoroutine(AumentarStamina());
	}
	
	// Update is called once per frame
	void Update () {
        limiteCantidad();
        Enfermedades();
            }

    IEnumerator AumentarStamina() {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            stamina += 1;
        }
    }

    void Enfermedades()
    {
        if (azucar > azucarMax)
        {
          //  diabetesText.enabled = true;
            diabetes = true;
        }
        if (grasa > grasaMax)
        {
           // colesterolText.enabled = true;
            colesterol = true;
        }
        if (calorias > caloriasMax)
        {
            // obesidadText.enabled = true;
            IncreaseSpeed.FindObjectOfType<IncreaseSpeed>().limite = 7;
            obesidad = true;
        }
        if (calorias < caloriasMax)
        {
            // obesidadText.enabled = false;
            IncreaseSpeed.FindObjectOfType<IncreaseSpeed>().limite = 5;
            obesidad = false;
        }
        Diabetes();
        Colesterol();
        Obesidad();
    }

    void Diabetes()
    {
        if (diabetes == true)
        {
            CameraShake.FindObjectOfType<CameraShake>().shake = true;

        }

    }

    void Colesterol()
    {
        if(colesterol == true)
        {


        }
    }

    void Obesidad()
    {
        if (obesidad == true)
        {

        }else if (obesidad == false)
        {

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lifeStats : MonoBehaviour {

    int x = 0;

    public int vida;
    public int azucar;
    public int grasa;
    public int calorias;
    public int stamina;
    [Header("ImagenesEnfermedades")]
    public AudioSource sonidoVirus;
    public GameObject imagenDiabetes;
    public GameObject imagenColesterol;
    public GameObject imagenObesidad;

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
        GameOver();
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
            imagenDiabetes.GetComponent<Image>().color = Color.white;
              diabetes = true;

        }
        if (grasa > grasaMax)
        {
            imagenColesterol.GetComponent<Image>().color = Color.white;   
            // colesterolText.enabled = true;
            colesterol = true;

        }
        if (calorias > caloriasMax)
        {
            imagenObesidad.GetComponent<Image>().color = Color.white;
            // obesidadText.enabled = true;
            IncreaseSpeed.FindObjectOfType<IncreaseSpeed>().limite = 7;
            obesidad = true;

        }
        if (calorias < caloriasMax)
        {
            imagenObesidad.GetComponent<Image>().color = Color.grey;
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
        if (diabetes == true && x==0)
        {
             CameraShake.FindObjectOfType<CameraShake>().shake = true;
        }

    }

    void Colesterol()
    {
        if (colesterol == true)
        {
        }
    }

    void Obesidad()
    {
  
        if (obesidad == true&& x ==0)
        {

        }
        else if (obesidad == false)
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
        }else if (stamina > 99)
        {
            stamina = 100;
        }

    }

    void GameOver()
    {
        if (colesterol == true && diabetes == true)
        {
            SceneManager.LoadScene("Main");
        }

        else if (calorias > caloriasMax+500)
        {
            SceneManager.LoadScene("Main");
        }
    }
}

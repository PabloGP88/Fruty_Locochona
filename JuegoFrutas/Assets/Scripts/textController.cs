using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textController : MonoBehaviour {
    public Text text;

    string frase_1 = "México es el primer lugar en obesidad infantil";
    string frase_2 = "6 de cada 10 adultos en México tiene problemas de sobrepeso";
    string frase_3 = "1 de cada 5 muertes en México es causada por diabetes";
    string frase_4 = "La principal fuente de energía son las calorías";
    string frase_5 = "México tiene el segundo lugar en consumo de pizza";
    string frase_6 = "Más de 1900 millones de adultos tienen problemas de nutrición";

    int seleccion;

    // Use this for initialization
    void Start()
    {
        int seleccion = (int)Random.Range(1, 6);

        if (seleccion == 1)
        {
            text.text = frase_1;
        }

        if (seleccion == 2)
        {
            text.text = frase_2;
        }

        if (seleccion == 3)
        {
            text.text = frase_3;
        }
        if (seleccion == 4)
        {
            text.text = frase_4;
        }
        if (seleccion == 5)
        {
            text.text = frase_5;
        }
        if (seleccion == 6)
        {
            text.text = frase_6;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

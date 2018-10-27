using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodStat : MonoBehaviour {

    public int azucar;
    public int grasa;
    public int calorias;

    private void Update()
    {
        limiteCantidad();
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

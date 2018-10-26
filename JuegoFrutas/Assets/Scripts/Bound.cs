using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        if (col.gameObject.tag == "Healthy")
        {
            Debug.Log("Comida Sana");
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "NoHealthy")
        {
            Debug.Log("Comida Chatarra");
            Destroy(col.gameObject);
        }

    }

}

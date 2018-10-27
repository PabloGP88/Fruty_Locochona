using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    [SerializeField]public Color[] colors; // 0 Rojo, 1 verde
    GameObject leftDoor;
    GameObject rightDoor;
    bool cambio;

    

    private void Start()
    {
        leftDoor = GameObject.Find("LeftDoor");
        rightDoor = GameObject.Find("RightDoor");
        // Color
        leftDoor.GetComponent<SpriteRenderer>().color = colors[1];
        rightDoor.GetComponent<SpriteRenderer>().color = colors[0];
    }

    private void Update()
    {
        EnableDisableDoors();

        if (leftDoor == null || rightDoor == null)
        {
            ReCheckDoors();
        }
    }



    void ReCheckDoors()
    {
        leftDoor = GameObject.Find("LeftDoor");
        rightDoor = GameObject.Find("RightDoor");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
    }

    void EnableDisableDoors()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cambio == false)
        {
            // Left Door
            leftDoor.GetComponent<BoxCollider2D>().enabled = true;
            leftDoor.GetComponent<SpriteRenderer>().color = colors[0];

            // Right Door
            rightDoor.GetComponent<BoxCollider2D>().enabled = false;
            rightDoor.GetComponent<SpriteRenderer>().color = colors[1];
            cambio = true;

        }
        else if (Input.GetKeyDown(KeyCode.Space) && cambio == true)
        {
            // Left Door
            leftDoor.GetComponent<BoxCollider2D>().enabled = false;
            leftDoor.GetComponent<SpriteRenderer>().color = colors[1];

            // Right Door
            rightDoor.GetComponent<BoxCollider2D>().enabled = true;
            rightDoor.GetComponent<SpriteRenderer>().color = colors[0];
            cambio = false;
        }
    }
}

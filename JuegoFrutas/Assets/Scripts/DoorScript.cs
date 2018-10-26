using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    [SerializeField]public Color[] colors; // 0 Rojo, 1 verde
    GameObject leftDoor;
    GameObject rightDoor;

    

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
        if (Input.GetKeyDown(KeyCode.Space) && leftDoor.GetComponent<SpriteRenderer>().color == colors[1]) { 
        leftDoor.GetComponent<SpriteRenderer>().color = colors[0];
        rightDoor.GetComponent<SpriteRenderer>().color = colors[1];
        }
        else if (Input.GetKeyDown(KeyCode.Space) && leftDoor.GetComponent<SpriteRenderer>().color == colors[0])
        {
            leftDoor.GetComponent<SpriteRenderer>().color = colors[1];
            rightDoor.GetComponent<SpriteRenderer>().color = colors[0];
        }


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
}

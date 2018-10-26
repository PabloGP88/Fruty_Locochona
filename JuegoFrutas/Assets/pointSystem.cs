using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointSystem : MonoBehaviour {

    public int points;

   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Healthy")
        {
            points += 1;
        }

        if (col.gameObject.tag == "Chatarra")
        {
            /// restar vida
        }

    }

}

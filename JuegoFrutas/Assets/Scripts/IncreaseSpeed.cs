using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Time.deltaTime < 5){
            Time.timeScale += 0.01f * Time.deltaTime;
        }
	}
}

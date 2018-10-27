using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour {
    public int limite = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Time.deltaTime < limite){
            Time.timeScale += 0.01f * Time.deltaTime;
        }
	}
}

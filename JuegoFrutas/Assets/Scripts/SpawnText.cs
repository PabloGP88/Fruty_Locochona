using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpawnText : MonoBehaviour {

    public Text textToShow ;

    private void Start()
    {
        textToShow.enabled = false;
    }
    private void OnMouseOver()
    {
        textToShow.enabled = true; 
    }
    private void OnMouseExit()
    {
        textToShow.enabled = false;
    }
}

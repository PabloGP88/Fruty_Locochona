using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpawnText : MonoBehaviour {
    public AudioSource popSound;
    public Text textToShow ;

    private void Start()
    {
        textToShow.enabled = false;
    }
    private void OnMouseEnter()
    {
        popSound.Play();
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

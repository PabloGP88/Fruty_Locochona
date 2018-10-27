using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLScript : MonoBehaviour {

    public void Link(string URL)
    {
        Application.OpenURL(URL);
    }
}

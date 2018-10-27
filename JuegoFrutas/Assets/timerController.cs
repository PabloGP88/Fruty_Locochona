using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerController : MonoBehaviour {

    public Text text;

    public float time;


    lifeStats ls;


    public Text HighScore;

    private void Start()
    {
        ls = FindObjectOfType<lifeStats>();
        HighScore.text = PlayerPrefs.GetFloat("HighScore", time).ToString("0.00");
    }

    void Update()
    {
       if (ls.diabetes == false && ls.colesterol == false || ls.calorias < ls.caloriasMax +500 )
        {
            time += Time.deltaTime;
            text.text = time.ToString("0.00");
        }

        PlayerPrefs.SetFloat("HighScore", time);

        if (time > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", time);
            HighScore.text = PlayerPrefs.GetFloat("HighScore", time).ToString("0.00");
        }

    }




 
}

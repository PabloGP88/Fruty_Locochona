using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
    public void ExitGame()
    {
        Application.Quit();
    }   
    public void SceneToLoad(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}

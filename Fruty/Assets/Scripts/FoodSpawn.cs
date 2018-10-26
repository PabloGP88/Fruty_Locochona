using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour {
    [Header("VariablesGlobales")]
    public bool inGame;
    [Header("Food")]
    public float SpawnTime;
    int randomSelect;
    public GameObject[] food;

    


    // -----------------------------------------------------
	void Start () {
        randomSelect = Random.Range(0, food.Length);
        inGame = GameManager.FindObjectOfType<GameManager>().inGame;
	}
	
	void Update () {

        StartCoroutine(Spawn());
	}
    IEnumerator Spawn()
    {
        if (inGame == true)
        {
            Instantiate(food[randomSelect]);
            yield return new WaitForSeconds(SpawnTime);
        }
    }
}

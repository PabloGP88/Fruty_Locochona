using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour {
    [Header("VariablesGlobales")]
    public bool inGame;

    [Header("Food")]
    public float SpawnTime;
    public float minTime;
    public float maxTime;
    public GameObject[] food;
    int randomSelect;

    // -----------------------------------------------------
    void Start () {
        // Spawn
        StartCoroutine(Spawn());
    }
	
	void Update () {
        
	}
    IEnumerator Spawn()
    {
        while (true)
        {
            SpawnTime = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(SpawnTime);
            randomSelect = Random.Range(0, food.Length);
            Instantiate(food[randomSelect],new Vector2(gameObject.transform.position.x,6),Quaternion.identity);
            

        }
    }
}

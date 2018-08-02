using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject Target;
    public GameObject AIPrefab;
    public float SpawnTime = 5;
    private float CurrentTime;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        CurrentTime -= Time.deltaTime;

        if (CurrentTime <= 0)
        {
            GameObject TempAI = Instantiate(AIPrefab, transform.position, transform.rotation);
            TempAI.GetComponent<AIMonsterController>().Target = Target;
            CurrentTime = SpawnTime;
        }
	}
}

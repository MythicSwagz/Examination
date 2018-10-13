using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStartP2 : MonoBehaviour {
    public float ySpawn;
    public float xSpawn;
    public Vector2 pos;
    // Use this for initialization
    void Start () {
        xSpawn = Random.Range(-8.5f, 8.5f);
        ySpawn = Random.Range(-4.5f, 4.5f);
        pos = new Vector2(xSpawn, ySpawn);
        transform.position = pos;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

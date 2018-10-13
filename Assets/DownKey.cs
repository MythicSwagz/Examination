using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownKey : MonoBehaviour {
    public float shipSpeed;
    // Use this for initialization
    void Start () {
        //Detta kommando bestämmer skeppets hastighet.
        shipSpeed = Random.Range(5, 16);
    }
	
	// Update is called once per frame
	void Update () {
        //Denna kod bestämmer om hastigheten är normal eller hälften. Om S är nedtryckt så är hastigheten hälften. Annars är den normal.
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(shipSpeed / 2 * Time.deltaTime, 0, 0, Space.Self);
        }
        else
        {
            transform.Translate(shipSpeed * Time.deltaTime, 0, 0, Space.Self);
        }
    }
}

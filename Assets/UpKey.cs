﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpKey : MonoBehaviour {
    public SpriteRenderer rend;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Denna kod gör att när spelaren trycker på "UpArrow" får skeppet en random färg.
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Detta kommando gör så att när man klickar på "Space" så får skeppet en random färg.
            rend.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }
}

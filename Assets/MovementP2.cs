using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP2 : MonoBehaviour {
    [Range(-720, 720)]
    public float rotationSpeed;
    public Color blueColor;
    public SpriteRenderer rend;
    public Color greenColor;
    // Use this for initialization
    void Start () {
        //Denna variabel bestämmer hur snabbt skeppet roterar.
        rotationSpeed = 200;
    }
	
	// Update is called once per frame
	void Update () {
        //Denna kod gör att skeppet svänger höger, att den byter färg till blå, att "rotationspeed" stannar som originalhastighet.
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotationSpeed = 200;
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
            rend.color = blueColor;
            rend.color = new Color(0, 0, 1);
        }
        //Denna kod gör att skeppet svänger vänster, att den byter färg till grön, att "rotationspeed" halveras.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotationSpeed = 100;
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
            rend.color = greenColor;
            rend.color = new Color(0, 1, 0);
        }
    }
}

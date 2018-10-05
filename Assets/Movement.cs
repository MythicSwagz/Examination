using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(-720, 720)]
    public float rotationSpeed;
    public Color blueColor;
    public SpriteRenderer rend;
    public float shipSpeed;
    public Color greenColor;
    public float slowShipSpeed;
    public float timer;
    public float timerStart;
    
    
    // Use this for initialization
    void Start()
    {
        //Denna variabel bestämmer hur snabbt skeppet roterar.
        rotationSpeed = 200;
        //Denna variabel bestämmer vilken siffra "timer" ska starta på.
        timerStart = 0;
        timer = timerStart;
    }

    // Update is called once per frame
    void Update()
    {
        //Denna kod gör att skeppet svänger höger, att den byter färg till blå, att "rotationspeed" stannar som originalhastighet.
        if (Input.GetKey(KeyCode.D))
        {
            rotationSpeed = 200;
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
            rend.color = blueColor;
            rend.color = new Color(0, 0, 1);
        }
        //Denna kod gör att skeppet svänger vänster, att den byter färg till grön, att "rotationspeed" halveras.
        if (Input.GetKey(KeyCode.A))
        {
            rotationSpeed = 100;
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
            rend.color = greenColor;
            rend.color = new Color(0, 1, 0);
        }
        //Denna kod bestämmer om hastigheten är normal eller hälften.
        if (Input.GetKey(KeyCode.S))
        {
            shipSpeed = 0;
            slowShipSpeed = 5;
            transform.Translate(slowShipSpeed * Time.deltaTime, 0, 0, Space.Self);
        }
        else
        {
            shipSpeed = 10;
            transform.Translate(shipSpeed * Time.deltaTime, 0, 0, Space.Self);
        }
        //Denna kod gör så att "timer" printas i konsollen.
        timer = timer + 1 * Time.deltaTime;
        print("Timer:" + timer);


    }
}

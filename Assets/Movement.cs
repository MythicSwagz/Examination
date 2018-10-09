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
    public float Timer;
    public float shipRandomColor1;
    public Color shipColorBase;
    public float xSpawn;
    public float ySpawn;
    public Vector2 pos;
    // Use this for initialization
    void Start()
    {
        //Denna variabel bestämmer hur snabbt skeppet roterar.
        rotationSpeed = 200;
        //Dessa kommandon ser till att skeppet startar på olika positioner.
        xSpawn = Random.Range(-8.5f, 8.5f);
        ySpawn = Random.Range(-4.5f, 4.5f);
        pos = new Vector2(xSpawn, ySpawn);
        transform.position = pos;
        //Detta kommando bestämmer skeppets hastighet.
        shipSpeed = Random.Range(5, 16);
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
            transform.Translate(shipSpeed / 2 * Time.deltaTime, 0, 0, Space.Self);
        }
        else
        {
            transform.Translate(shipSpeed * Time.deltaTime, 0, 0, Space.Self);
        }
        //Detta kommando ser till att timern fungerar.
        if (Time.fixedTime == Timer)
        {
            Timer = Timer + 1;
            print("Sekunder:" + Timer);
        }

        //Denna kod gör att när spelaren trycker på "Spacebar" får skeppet en random färg.
        if (Input.GetKey(KeyCode.Space))
        {
            //Detta kommando gör så att när man klickar på "Space" så får skeppet en random färg-
            rend.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        //Detta kommando skapar en variabel som får skeppets position.
        Vector3 newPosition = transform.position;
        //Detta kommando ser till att skeppet inta kan åka utanför skärmen på höger eller vänster sida. Den kommer till sin motsatta sida om den åker utanför.
        if (newPosition.x > 9 || newPosition.x < -9)
        {
            newPosition.x = -newPosition.x;
        }
        //Detta kommando ser till att skeppet inte kan åka utanför skärmen uppåt eller nedåt. Den kommer till sin motsatta sida om den åker utanför.
        if (newPosition.y > 5 || newPosition.y < -5)
        {
            newPosition.y = -newPosition.y;
        }
        transform.position = newPosition;

    }
}

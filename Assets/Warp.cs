using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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

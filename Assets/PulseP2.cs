using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseP2 : MonoBehaviour {
    Renderer rend;
    public float pulseColorRed;
    public float pulseColorGreen;
    public float pulseColorBlue;
    public Color pulseColor;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        pulseColorRed = 1f;
        pulseColorGreen = 1f;
        pulseColorBlue = 1f;
    }
	
	// Update is called once per frame
	void Update () {
        //Pulsen är en blandning mellan dessa färger.
        pulseColor = new Color(pulseColorRed, pulseColorGreen, pulseColorBlue);
        //Denna kod gör att färgen "Red" sänks några gånger i sekunden.
        pulseColorRed -= 0.01f * Time.deltaTime * 50;
        //Denna kod gör att färgen "Green" sänks några gånger i sekunden.
        pulseColorGreen -= 0.01f * Time.deltaTime * 50;
        //Denna kod gör att färgen "Blue" sänks några gånger i sekunden.
        pulseColorBlue -= 0.01f * Time.deltaTime * 50;
        //Denna kod renderar den sänkta färgen.
        rend.material.color = pulseColor;
        //Om "Red" är mindre än 0, går den tillbaka upp till original.
        if (pulseColorRed <= 0)
        {
            pulseColorRed = 1f;
        }
        //Om "Green" är mindre än 0, går den tillbaka upp till original.
        if (pulseColorGreen <= 0)
        {
            pulseColorGreen = 1f;
        }
        //Om "Blue" är mindre än 0, går den tillbaka upp till original.
        if (pulseColorBlue <= 0)
        {
            pulseColorBlue = 1f;
        }
    }
}

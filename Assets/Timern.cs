using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timern : MonoBehaviour
{
    public float Timer;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Detta kommando ser till att timern fungerar.
        if (Time.fixedTime == Timer)
        {
            print("Sekunder:" + Timer);
            Timer = Timer + 1;
        }
    }
}

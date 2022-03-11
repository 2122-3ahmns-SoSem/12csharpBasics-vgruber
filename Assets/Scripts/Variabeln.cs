using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}


public class Variabeln : MonoBehaviour
{


    Color farbe;
    int anzTueren;
    bool fahren;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Himmelsrichtungen.Nord + " " + Himmelsrichtungen.Sued + " " + Himmelsrichtungen.Ost + " " +Himmelsrichtungen.West );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        if(Input.anyKeyDown)
        {
            switch(Input.inputString.ToUpper())
            {
                case "E":
                
                    break;
                case "S":
                    // Speichern
                    break;
            }
        }
    }
}

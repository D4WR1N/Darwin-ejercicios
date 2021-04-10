using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lopeacion : MonoBehaviour
{
    int numeroDeArañas = 3;


    void Start()
    {
        for (int i = 0; i < numeroDeArañas; i++)
        {
            print("Son bastantes arañas, oh con esta van " + i);
        }

    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    public float TemperaturaDelCafe = 63f;
    float LimiteCalienteDeLaTemperatura = 80f;
    float LimiteFrioDeLaTemperatura = 20f;

    void Update()
    {
        if (TemperaturaDelCafe > LimiteCalienteDeLaTemperatura)
        {
            print("We te mamaste, te vas a quemar");
        }
        if (TemperaturaDelCafe < LimiteFrioDeLaTemperatura)
        {
            print("Buah tomas un poco y se te congela el cerebro");
        }
        else
        {
            print("Perfectamente balanceado como debe de estar");
        }

        
    }
}

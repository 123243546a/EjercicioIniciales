using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    float Convertir(float cantidad, string moneda) 
    {
        float eurosADollares = 1.1f;
        float DollaresAEuros = 1 / eurosADollares;

        float resultado = 0;

        if (moneda.ToLower() == "euros")
        {
            resultado = cantidad * eurosADollares;
        }
        else if (moneda.ToLower() == "dollares")
        {
            resultado = cantidad * DollaresAEuros;
        }
        
        return resultado;
    }
   

    // Start is called before the first frame update
    void Start()
    {
        float euros = 20f;
        float dollares = 12;

        float eurosADollares = Convertir(euros, "euros");
        float dollaresAEuros = Convertir(dollares, "dollares");

        Debug.Log(euros + " euros son " + eurosADollares + " dólares.");
        Debug.Log(dollares + " dólares son " + dollaresAEuros + " euros.");

    }

    // Update is called once per frame
    
    
}

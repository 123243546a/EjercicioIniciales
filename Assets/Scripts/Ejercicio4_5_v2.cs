using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5_v2 : MonoBehaviour
{
    int lado = 2;
    int lado2 = 2;
    int cantidadMonedas = 4;
    float convertir = 2.4f;

    float Cuadrado(int lado, int lado2)
    {
        float cuadrado = (lado * lado2);
        return cuadrado;
    }

    // Start is called before the first frame update
    void Start()
    {
        int cantidadMonedas = 4;
        float cantidadConvertida = Convertir(cantidadMonedas);
        Debug.Log("Cantidad de monedas = " + cantidadMonedas);
        Debug.Log("Cantidad convertida = " + cantidadConvertida);
    }

    // Update is called once per frame
    float Convertir(float cantidad)
    {
        float rr = cantidad * 2.4f;
        return rr;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    float vehiculo1 = 14f;
    float vehiculo2 = 18f;
    float vehiculo3 = 68f;
    float velocidadKmh;
    float velocidadMs;
    // Start is called before the first frame update
    void Start()
    {
        velocidadMs = velocidadKmh * 0.27778f;
        vehiculo1 = 14 / velocidadKmh;
        vehiculo2 = 18 / velocidadKmh;
        vehiculo3 = 68 / velocidadKmh;
        Debug.Log("La velocidad en m/s es: " + velocidadMs);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

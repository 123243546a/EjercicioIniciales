using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultado = Convertir;
        
    }

    // Update is called once per frame
    float Convertir(float cantidad)
    {
        float resultado = cantidad / 0.9f;
        return (resultado);
    }
}

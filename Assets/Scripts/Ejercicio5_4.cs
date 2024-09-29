using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    float dividendo;
    float divisor;
    // Start is called before the first frame update
    void Start()
    {
        if (divisor /= 0)
        {
            float resultado = dividendo / divisor;
            Debug.Log("El resultado de esta división es: " + resultado);
        }

        if (divisor == 0)
        {
            Debug.Log("Error: El resultado de divisor no puede ser igual a 0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

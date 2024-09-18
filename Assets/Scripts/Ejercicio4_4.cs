using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    float velocidadKmh = 12;
    float velocidadMps = 3.33f;
    // Start is called before the first frame update
    void Start()
    {
        velocidadKmh = velocidadMps * 3.60f;
        Debug.Log("12 kmh es igual a " + velocidadKmh);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

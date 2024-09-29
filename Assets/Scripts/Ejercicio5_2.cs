using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    int numero1;
    int numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 < 3) 
        {
            Debug.Log("El primer número es menor que 3.");
        }
        
        if (numero2 < 3) 
        {
            Debug.Log("Ambos numeros son menores a 3.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

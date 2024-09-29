using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    int num;
    // Start is called before the first frame update
    void Start()
    {
        if (num >= 0) 
        {
            Debug.Log("Ingresa un número positivo y entero.");
            return;
        }

        Debug.Log("Múltiplos de 3 desde 1 hasta {num}:");

        for (int i = 1; i <= num; i++) 
        {
            if (i % 3 == 0) 
            {
                Debug.Log(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

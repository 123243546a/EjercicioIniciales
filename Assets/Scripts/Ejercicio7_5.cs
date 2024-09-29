using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    int number;
    // Start is called before the first frame update
    void Start()
    {
        if (number <= 0)
        {
            Debug.Log("Ingrese número positivo");
        }

        for (int i = 1; i <= number; i++) 
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

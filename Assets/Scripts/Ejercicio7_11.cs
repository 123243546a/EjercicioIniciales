using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    int number = 2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("La tabla de multiplicar del {number} ");

        for (int i = 1; i <= 10; i++)

        {
            int resultado = number * i;
            Debug.Log ("{number} x {i} = {resultado}")
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

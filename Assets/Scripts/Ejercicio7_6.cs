using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    int num;
    // Start is called before the first frame update
    void Start()
    {
        if (num <= 0) 
        {
            Debug.Log("Ingrese número positivo");

        }

        int i = num;
        while (i >= -num) 
        {
            Debug.Log(i);
            i--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

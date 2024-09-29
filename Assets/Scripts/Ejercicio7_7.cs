using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    int num1;
    int num2;
    // Start is called before the first frame update
    void Start()
    {
        int min = Mathf.Min(num1, num2);
        int max = Mathf.Max(num1, num2);

        Debug.Log("Muestra los números desde {min} hasta {max}:");
        for (int i = min; i <= max; i++) 
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

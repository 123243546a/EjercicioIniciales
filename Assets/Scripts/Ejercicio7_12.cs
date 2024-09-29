using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numero1 = 5;
        int numero2 = 10;

        int suma = SumarTodosLosNumeros(numero1, numero2);
        Debug.Log("La suma de todos los números entre {numero1} y {numero2} es: {suma}");
    }

    
    int SumarTodosLosNumeros(int num1, int num2)
    {
        int menor = Mathf.Min(num1, num2);
        int mayor = Mathf.Max(num1, num2);
        int suma = 0;

        for (int i = menor; <= mayor; i++) 
        {
            suma += i;
        }

        return suma;
    }
}

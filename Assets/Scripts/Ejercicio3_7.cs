using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    int basee = 3;
    int altura = 4;
    float area;

    // Start is called before the first frame update
    void Start()
    {
        area = (basee * altura) / 2;
        Debug.Log("El area del triangulo es de " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

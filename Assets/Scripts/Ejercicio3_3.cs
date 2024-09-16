using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    int numero;
    int doble;
    int triple;
    // Start is called before the first frame update
    [SerializeField]void Start()
    {
        doble = numero * 2;
        triple = numero * 3;
    }

    // Update is called once per frame
    [SerializeField]void Update()
    {
        Debug.Log("El doble de " + numero + " es: " + doble);
        Debug.Log("El triple de " + numero + " es: " + triple);
    }
}

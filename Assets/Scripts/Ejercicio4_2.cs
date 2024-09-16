using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string resultado = HacerSaludo("Juan", "Perez", "Gonzalez", 29);
        Debug.Log(resultado);
       
    }

    // Update is called once per frame
    string HacerSaludo(string nombre, string apellido1, string apellido2, int edad)
    {
        string saludo = "La persona se llama " + nombre + " " + apellido1 + " " + apellido2 + " y tiene " + edad;
        return saludo;
    }
}

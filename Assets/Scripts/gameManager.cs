using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    private string nombre;
    private float vida;
    private float experiencia;

    public float CalcularNivel() 
    {
        CalcularNivel = experiencia / 1000;
        return CalcularNivel;

        
    }
}

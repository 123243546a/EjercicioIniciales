using System.Collections;
using System.Collections.Generic;
using UnityEditor.Media;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int goles = 4;
    int faltas = 8;
    int fuerasDeJuego = 3;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float media = goles + faltas + fuerasDeJuego / 3;
    }
}

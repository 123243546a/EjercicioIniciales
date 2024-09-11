using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 2;
    float exp = 1.6f;
    
    // Start is called before the first frame update
    void Start()
    {
        float producto = vidas * exp; 
        float cociente = vidas / exp;
        float resto = vidas % exp;
        float dobleVidas = vidas * 2;
        float tripleExp = exp * 3;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

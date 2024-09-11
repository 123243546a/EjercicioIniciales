using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio2_2 : MonoBehaviour
{
    int vida = 2;
    float exp = 2.8f;
    char carac = 'a';
    float resultadoSuma;
    float resultadoResta;    
    // Start is called before the first frame update
    void Start()
    {
        float resultadoSuma = vida + exp;
        float resultadoResta = vida - exp;
        Debug.Log("El valor de las variables " + vida + " " +  exp);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int unidades = 7;
    int segundos = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        float oro = unidades * segundos;
    }

    // Update is called once per frame
    void Update()
    {
        float oro = segundos * 60 * 60 * 4;
    }
}

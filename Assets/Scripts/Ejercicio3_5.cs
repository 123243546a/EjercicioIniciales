using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    float Area;
    float radio = 5;
    float longitud;
    // Start is called before the first frame update
    void Start()
    {
        longitud = 2 * 3.1415f * radio;
        Area = 3.1415f * (radio * radio);
        Debug.Log("La longitud de la circunferencia es: " + longitud);
        Debug.Log("El área de la circunferencia es: " + Area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

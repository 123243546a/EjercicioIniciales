using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    int vidaPersonaje1;
    int vidaPersonaje2;
    // Start is called before the first frame update
    void Start()
    {
        if (vidaPersonaje1 == vidaPersonaje2)
        {
            Debug.Log("La batalla está igualada");
        }
        if (vidaPersonaje1 /= vidaPersonaje2)
        {
            Debug.Log("La batalla no está igualada");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

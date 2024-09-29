using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int numero;
    // Start is called before the first frame update
    void Start()
    {
        if (numero >= 0)
        {
            if (numero <= 9)
            {
                Debug.Log("El número está comprendido entre 0 y 9.");
            }
        }

        if (numero < 0 || numero > 9)
        {
            Debug.Log("El número no está comprendido entre 0 y 9");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

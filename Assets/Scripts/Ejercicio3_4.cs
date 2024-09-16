using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    int EXP = 35;
    int LVL;
    // Start is called before the first frame update
    [SerializeField]void Start()
    {
        LVL = 32 + (9 * EXP / 5);
        Debug.Log("El nivel del jugador es de " + LVL);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

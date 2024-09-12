using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidas = vidas + 77;
        vidas = vidas - 3;
        vidas = vidas * 4;

    }
}

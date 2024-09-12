using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clase : MonoBehaviour
{
    float variableGlobal = 9;
    // Start is called before the first frame update
    void Start()
    {
        SumarDosNumeros(8, 3);
        SumarDosNumeros(1, 2);
        SumarDosNumeros(3, 6);
        HacerSuperNena(2.7f, 4, "Pétalo", 3);
        
    }


    void SumarDosNumeros(int numero1, int numero2) 
    {
       
        int resultado = numero1 + numero2;
        Debug.Log(resultado);
    }

    void HacerSuperNena (float azucar, int especias, string nombre, int flores)
    {

    }




}

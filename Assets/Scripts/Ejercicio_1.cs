using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_1 : MonoBehaviour
{
    //Declarar la variable(nombre de la caja), asignación de la variable (el número de cosas que metes en la caja)

    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("¡Hola mundo!");
        Debug.Log("Este es el primer videojuego de Adrián");
        Debug.Log("Estoy aprendiendo C#");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame");
        //Porque lo hemos puesto en Update y eso significa que se actualiza cada frame, es decir aparece X veces por segundo dependiendo de los fps.
    }
}

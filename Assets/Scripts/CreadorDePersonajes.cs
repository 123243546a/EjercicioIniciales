using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorDePersonajes : MonoBehaviour
{
    [SerializeField]Personaje link = null;
    [SerializeField]Personaje mario = null;
    [SerializeField]Personaje sonic = null;
    [SerializeField]GameObject camara = null;
    Rigidbody rb;


    void Start()
    {
        link.Vida = 150;

        if (link.Vida > 0)
        {
            Debug.Log("Link está vivo");
        }

        link.Mover(1, 3, 0);
        mario.Mover(2, 6, 0);
    }

}

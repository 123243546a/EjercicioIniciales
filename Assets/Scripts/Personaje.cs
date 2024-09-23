using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private float vida;
    private float velocidad;
    private float danho;
    private float experiencia;
    private string nombre;
    private int mana;

    public float Vida { get => vida; set => vida = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public float Velocidad { get => velocidad; set => velocidad = value; }
    public float Danho { get => danho; set => danho = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public int Mana { get => mana; set => mana = value; }

    public void Atacar()
    {
        
    }

    public void Mover(float x, float y, float z)
    {
        
    }

    public void Saltar()
    {
        
    }

    public void Morir()
    {
        
    }
}

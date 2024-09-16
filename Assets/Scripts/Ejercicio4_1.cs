using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float circulo;
        float trinagulo;
    }   float cuadrado;

    // Update is called once per frame
    float Circulo(int radio, float Pi)
    {
        float circulo = (radio * 3) * Pi;
        return circulo;
    }
    float Triangulo(int basee, int altura)
    {
        float triangulo = (basee * altura) / 2;
        return triangulo;
    }
    float Cuadrado(int lado, int lado2)
    {
        float cuadrado = (lado * lado2);
        return cuadrado;
    }
}

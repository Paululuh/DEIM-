using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    // Zona variables globales
    // Números que usaremos para el incremento en orden.
    public int NumberOne,
               NumberTwo,
               NumberThree;

    void Start()
    {
        // Llamamos al método.
        GetDescendingOrder();

    }

    // Crearemos un método que incrementará en orden los números.
    private void GetDescendingOrder()
    {
        // Comprobamos si el primer número es igual o mayor que el segundo.
        // Y también comprobamos si el segundo es igual o mayor que el tercero.
        if ((NumberOne >= NumberTwo) && (NumberTwo >= NumberThree))
        {
            // Si es así, mostramos en la consola que el orden es decreciente.
            Debug.Log("Los números " + NumberOne + ", " + NumberTwo + " y " + NumberThree + " orden decreciente.");
        }

        else
        {
            // Si no es así, mostramos en la consola que el orden no es decreciente.
            Debug.Log("Los números" + NumberOne + ", " + NumberTwo + " y " + NumberThree + " no orden decreciente.");
        }
    }
}
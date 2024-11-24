using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    // Zona variables globales
    // Números que usaremos para el incremento en orden.
    public int NumberOne,
               NumberTwo,
               NumberThree;

    void Start()
    {
        // Llamamos al método.
        GetIncreasingOrder();

    }

    // Crearemos un método que incrementará en orden los números.
    private void GetIncreasingOrder()
    {
        // Comprobamos si el primer número es igual o menos que el segundo.
        // Y también comprobamos si el segundo es igual o menor que el tercero.
        if ((NumberOne <= NumberTwo) && (NumberTwo <= NumberThree))
        {
            // Si es así, mostramos en la consola que el orden es creciente.
            Debug.Log("Los números " + NumberOne + ", " + NumberTwo + " y " + NumberThree + " orden creciente.");
        }

        else
        {
            // Si no es así, mostramos en la consola que el orden no es creciente.
            Debug.Log("Los números" + NumberOne + ", " + NumberTwo + " y " + NumberThree + " no orden creciente.");
        }
    }
}
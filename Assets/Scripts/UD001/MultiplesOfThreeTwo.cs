using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{

    void Start()
    {
        // Llamamos al método.
        GetMultiplesOfThreeTwo();
    }

    private void GetMultiplesOfThreeTwo()
    {
        // Creamos una variable para el incremento.
        int i = 1;

        // Creamos un bucle controlado.
        while (i <= 100)
        {
            // Comprobamos si i dividido entre 2, su resto es igual a 0.
            if (i % 2 == 0)
            { 

                // Si es así, lo mostramos la consola.
                Debug.Log(i + " es multiplo de 2");
            }

            //Comprobamos si i dividido entre 3, su resto es ifual a 0.

            else if (i % 3 == 0)
            
        {
            // Si es así, lo mostramos en la consola.
            Debug.Log(i + " es multiplo de 3");
        }

            // Incrementamos el i.
            i++;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
  
    void Start()
    {
        // Llamamos al método.
        GetMultiplesOfThree();

    }

    private void GetMultiplesOfThree()
    {
        // Creamos una variable para el incremento.
        int i = 0;

        // Creamos un bucle controlado.
        while (i <= 100)
        { 
            // Comprobamos si i dividido entre 3, su resto es diferente a 0.
            if (i % 3 !=0)
            {

            // Si es así, lo mostramos en pantalla.
            Debug.Log(i);

        }

        // Incrementamos el i.
        i++;
        }
    }
}
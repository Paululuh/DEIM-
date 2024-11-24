using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    void Start()
    {
        // Llamamos al método.
        GetEvenNumbers0To100while();
    }

    private void GetEvenNumbers0To100while()
    {
        // Creamos la variable para el incremento.
        int i = 0;

        // Creamos el bucle controlado.
        while (i <= 100)
        {
            // Comprobamos si i dividido entre 2, da como resto igual a 0.
            if (i % 2 == 0)
            {
                // Si es así, lo mostramos en la consola.
                Debug.Log(i);
            }
            // Incrementamos el i.
            i++;
        }

    }

}


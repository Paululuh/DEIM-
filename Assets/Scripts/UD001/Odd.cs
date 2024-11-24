using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    void Start()
    {
        // Llamamos al método.
        GetOddNumbers0To100While();
    }

    private void GetOddNumbers0To100While()
    {
        // Creamos una variable que usaremos para el incremento.
        int i = 0;

        // Creamos un bucle controlado
        while (i <= 100)
        {
            // Comprobamos si i dividido entre 2, cuyo resto es distinto de 0.
            if (i % 2 != 0)
            {
                // Si es así, lo mostramos en la consola.
                Debug.Log(i);
            }
            // Incrementamos el i.
            i++;
        }
    }
}
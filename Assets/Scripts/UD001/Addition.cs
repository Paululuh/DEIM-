using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    //Variable globales dentro de la clase

    //Número introducido
    public int numberIntroducted;

    void Start()
    {
        //Llamamos al método y le añadimos el parámetro
        numberAddiction(numberIntroducted);
    }
    private void numberAddiction(int number)
    {
        //Número a añadir
        int numberAdd = 0;

        //Nos aseguramos de que el número que se coloque pueda ser sumado
        if (number >= 0)
        {
            //Se crea un bucle de suma de valores
            for (int i = 1; i <= number; i++)
            {
                //Añadimos el número
                numberAdd += i;
            }
            //Mostramos en consola el mensaje
            Debug.Log("La suma de los números entre 1 y el número " + number + " es " + numberAdd + ".");
        }
        else
        {
            //Mostramos en consola un mensaje de que ponga un número que pueda sumarse
            Debug.Log("El número " + number + " no puede sumarse.");
        }
    }

}

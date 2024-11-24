using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    // Variables globales
    // Números que usaremos para comprobarlos.
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree; 

    void Start()
    {
        // Llamamos al método
        AscendingNumber();
    }

    // Creamos un método para comparar números del más pequeño al más grande.
    private void AscendingNumber()
    {
        // Almacenamos los números correspondientes en estas variables locales.
        int numberSmallest = 0;
        int numberMiddle = 0;
        int numberLargest = 0;

        // Comprobamos si el primer número es menor que el segundo y el tercero.
        // "Number1" < "Number2" y "Number1 < "Number3"
        if (NumberOne < NumberTwo && NumberOne < NumberThree)
        {
            // Si es así, lo almacenamos como número más pequeño.
            numberSmallest = NumberOne;

            // Si el primer número no es el más pequeño, comprobamos si el segundo si lo es "Number1" < "Number2" < "Number3"
            if (NumberTwo < NumberThree)
            {
                // Si es así, almacenamos el segundo como el número intermedio y el tercero como el más grande.
                numberMiddle = NumberTwo;
                numberLargest = NumberThree;

            }
            // Si no, el tercero es el intermedio y el segundo el más grande.
            // "Number1" < "Number3" < "Number2"
            else
            {
                numberMiddle = NumberThree;
                numberLargest = NumberTwo;
            }
        }
        // Comprobamos si el segundo número es el más pequeño que los demás.
        // "Number2" < "Number1 y "Number2 < "Number3"  
        else if (NumberTwo < NumberOne && NumberTwo < NumberThree)
        {
            // Si es así, lo almacenamos como el más pequeño.
            numberSmallest = NumberTwo;

            // Comprobamos si el primero es más pequeño que el tercero.
            // "Number2 < "Number1" < "Number3"
            if (NumberOne < NumberThree)
            {
                // Si es así, almacenamos el primero como el intermedio y el tercero como el más grande.
                numberMiddle = NumberOne;
                numberLargest = NumberThree;

                // Comprobamos si el tercero es más pequeño que el primero.
                // "Number2" < "Number3" < "Number1"
                if (NumberThree < NumberOne)
                {
                    // Si es así, almacenamos el segundo como el intermedio y el primero como el más grande.
                    numberMiddle = NumberTwo;
                    numberLargest = NumberOne;
                }

                // Si no, el primer número será el intermedio y el segundo el más grande.
                // "Number3" < "Number1" > "Number2"
                else
                {
                    numberMiddle = NumberOne;
                    numberLargest = NumberTwo;
                }
            }

            // Mostrar en la consola los números en orden.
            Debug.Log("Orden ascendente de los números es: '" + numberSmallest + "' , '" + numberMiddle + "' , '" + numberLargest + "' .");
        }
    }
}

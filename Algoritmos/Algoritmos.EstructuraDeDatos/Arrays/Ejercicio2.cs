using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.EstructuraDeDatos.Arrays
{
    public class Ejercicio2
    {
        /// <summary>
        /// Metodo que ordena el array de menor a mayor usando el algoritmo Bubble Sort
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public int[] BubbleShort(int[] values)
        {
            // definimos la vandera
            bool flag = true;
            // definimos una variable temporal
            int temp;
            // optenemos la longitud del array
            int lengtArray = values.Length;

            // recorremos el array hasta que ((i <= (numLength - 1)) && flag)
            for (int i = 1; (i <= (lengtArray - 1)) && flag; i++)
            {
                flag = false;

                // realizamos el segundo recorrido 
                for (int j = 0; j < (lengtArray - 1); j++)
                {
                    // Validamos las posiciones [0] con la [1]
                    if (values[j + 1] < values[j])
                    {
                        // asignamos el valor de la posicion [j] ala variable temporal
                        temp = values[j];
                        // intercambiamos valores
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            return values;
            
        }
    }
}

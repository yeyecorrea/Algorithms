using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.EstructuraDeDatos.Arrays
{
    public class Ejercicio1
    {
        /// <summary>
        /// Metodo que encuentra el valor mas bajo de un array, usando la estructura de datos array
        /// </summary>
        /// <returns></returns>
        public int ValueMin(int[] values)
        {
            // Definimos un primer valor
            int minValue = values[0];

            // Recorremos el array
            for (int i = 0; i < values.Length; i++)
            {
                // Validamos el primer valor con el actual en el indice
                if (i < minValue)
                {
                    // Asignamos el valor menor
                    minValue = i;
                }
            }

            return minValue;
        }
    }
}

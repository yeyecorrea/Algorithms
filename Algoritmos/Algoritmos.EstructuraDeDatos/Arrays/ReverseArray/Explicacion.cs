using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.EstructuraDeDatos.Arrays.ReverseArray
{
    public class Explicacion
    {
        /// <summary>
        /// Metodo que invierte un array utilizando una matriz adicional
        /// </summary>
        /// Complejidad de tiempo : O(n) - Copia elementos a una nueva matriz en una operacion lineal
        /// Complejidad del espacio: O(n) - Se utiliza espacio adicional para almacenar la nueva matriz
        /// <param name="arr"></param>
        public int[] ReverseArrayExtraArray(int[] arr)
        {
            // Se crea una nueva matriz del mismo tamaño que la matriz original
            int[] reverseArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                // Se copian los elementos de la matriz original a la nueva matriz en orden inverso
                reverseArr[i] = arr[arr.Length - i - 1];
            }

            return reverseArr;
        }

        /// <summary>
        /// Metodo que invierte una Matriz usando un bucle
        /// </summary>
        /// Complejidad de tiempo : O(n) - El bucle recorre la mitad de la matriz, por lo que es lineal con respecto al tamaño de la matriz
        /// Complejidad del espacio: O(n) - Inversion in situ, lo que significa que no utiliza espacio adicional
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public int[] ReverseArray(int[] arr, int start, int end)
        {
            int temp;

            // Iteramos entre dos punteros (inicicio y final)
            while (start < end)
            {
                temp = arr[start];
                // Intercambiamos elementos entre el punto inicio y el final
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            return arr;

        }

        /// <summary>
        /// Metodo que invierte un array de enteros utilizando metodos incorporados como Reverse en c#
        /// </summary>
        public void OriginalArray(int[] arr)
        {
            // Reversamos el array
            Array.Reverse(arr);

            // Mostramos el array
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Metodo que invierte una matriz utilizando recursividad
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void ReverseArrayRecursive(int[] arr, int start, int end)
        {
            int temp;
            if (start >= end)
                return;

            temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            ReverseArrayRecursive(arr, start + 1, end - 1);
        }

        /// <summary>
        /// Metodo que invierte una matriz utilizando un stack
        /// </summary>
        /// <param name="arr"></param>
        public void ReverseArrayUsingStack(int[] arr)
        {
            // Stack es una coleccion que almacena elementos de forma LIFO (last in first out)
            // lo que quiere decir que el ultimo elemento que ha entrado, va a ser el primero de la lista
            Stack<int> stack = new Stack<int>();

            foreach (var element in arr)
            {
                // Insertamos el el elemento en el stack
                stack.Push(element);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                // Extraemos los elementos del stack al array
                arr[i] = stack.Pop();
            }
        }

    }
}
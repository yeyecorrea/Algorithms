using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.EstructuraDeDatos.Arrays.ReverseArray.Ejercicios
{
    public class Ejercicio1
    {
        public string reverseWords(string s)
        {
            string[] cadena = s.Split('.');

            Array.Reverse(cadena);
            string cadenaInvertida = String.Join(".", cadena);

            return cadenaInvertida;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.EstructuraDeDatos.Arrays.ReverseArray.Ejercicios
{
    public class Ejercicio2
    {
        public char[] reverseWords(string s)
        {
            char[] strings = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                strings[i] = s[s.Length - i - 1];
            }

            return strings;
        }
    }
}

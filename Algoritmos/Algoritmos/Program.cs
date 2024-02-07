using Algoritmos.EstructuraDeDatos.Arrays;
using Algoritmos.EstructuraDeDatos.Arrays.ReverseArray;

Ejercicio2 ejercicio2 = new Ejercicio2();
int[] values = { 10, 2, 4, 8, 1, 6};
int[] result = ejercicio2.BubbleShort(values);

foreach (var item in result)
{
    Console.WriteLine(item);
}
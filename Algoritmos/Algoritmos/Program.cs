using Algoritmos.EstructuraDeDatos.Arrays.ReverseArray;

Explicacion explicacion = new Explicacion();
int[] values = explicacion.ReverseArrayExtraArray(new int[] {1,2,3,4,5,6,7,8,9});
int[] values2 = explicacion.ReverseArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0, 8);
Console.WriteLine($"Resultado 1{values[0]}");
Console.WriteLine($"Resultado 2{values2[0]}");
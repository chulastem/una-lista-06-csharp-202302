using System;

public class Program
{
    public static void Main()
    {
        int[,] matriz = new int[3, 3]; // Cria uma matriz 3x3 de inteiros

        // Inicializa os elementos da matriz
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[0, 2] = 3;
        matriz[1, 0] = 4;
        matriz[1, 1] = 5;
        matriz[1, 2] = 6;
        matriz[2, 0] = 7;
        matriz[2, 1] = 8;
        matriz[2, 2] = 9;

        // Acessa e imprime elementos da matriz
        Console.WriteLine("Elemento na linha 1, coluna 2: " + matriz[0, 1]); // Saída: 2
    }
}
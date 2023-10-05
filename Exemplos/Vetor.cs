using System;

public class Program
{
	public static void Main()
	{
		int[] vetor = new int[5]; // Cria um vetor de inteiros com tamanho 5

		// Inicializa os elementos do vetor
		vetor[0] = 10;
		vetor[1] = 20;
		vetor[2] = 30;
		vetor[3] = 40;
		vetor[4] = 50;

		// Acessa e imprime elementos do vetor
		Console.WriteLine("Elemento 2 do vetor: " + vetor[1]); // Saída: 20
	}
}
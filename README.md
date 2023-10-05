# una-lista-06-csharp-202302
Lista de Exercícios VI: Revisão

## Explique o que é um vetor, uma matriz e um cubo em estrutura de dados.

1. **Vetor:** Um vetor é uma estrutura de dados que armazena uma coleção de elementos do mesmo tipo de forma contígua na memória. Cada elemento é acessado por um índice único que começa em 0. Os vetores têm um tamanho fixo e são usados para armazenar dados simples, como números inteiros, números reais, caracteres, etc.
2. **Matriz:** Uma matriz é uma estrutura de dados bidimensional que armazena elementos em linhas e colunas. Cada elemento de uma matriz é acessado por um par de índices, um para a linha e outro para a coluna. Matrizes são usadas para armazenar dados tabulares ou dados que têm uma relação de duas dimensões, como uma planilha.
3. **Cubo :** Um cubo é uma estrutura de dados tridimensional que é semelhante a uma matriz, mas tem três dimensões: comprimento, largura e altura. Cada elemento de um cubo é acessado usando três índices, um para cada dimensão. Cubos são usados quando você precisa armazenar e manipular dados que têm uma estrutura tridimensional, como uma matriz tridimensional ou uma coleção de dados volumétricos.

## Escreva em C# exemplos de um vetor e de uma matriz.

Aqui estão exemplos em C# de um vetor e uma matriz:

**Exemplo de Vetor (Array):**

```csharp
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
```

**Exemplo de Matriz (Array Bidimensional):**

```csharp
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
```

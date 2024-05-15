using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.Write("Digite o número de linhas (M): ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de colunas (N): ");
        int N = int.Parse(Console.ReadLine());

        
        int[,] matriz = new int[M, N];

       
        Console.WriteLine("Digite os elementos da matriz:");
        for (int i = 0; i < M; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = int.Parse(linha[j]);
            }
        }

        
        Console.Write("Digite o número inteiro X: ");
        int X = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matriz[i, j] == X)
                {
                    Console.WriteLine($"Posição {i},{j}:");
                    if (j > 0)
                    {
                        Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Acima: " + matriz[i - 1, j]);
                    }
                    if (j < N - 1)
                    {
                        Console.WriteLine("Direita: " + matriz[i, j + 1]);
                    }
                    if (i < M - 1)
                    {
                        Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                    }
                }
            }
        }
    }
}

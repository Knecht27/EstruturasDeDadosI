
using System;

class Programa
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        Console.WriteLine("Bem-vindo ao programa de matriz 3x3!");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                bool posicaoJaEscolhida = false;
                do
                {
                    Console.Write($"Digite um valor (0 ou 1) para a posição [{i}, {j}]: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        if (valor == 0 || valor == 1)
                        {
                            if (matriz[i, j] == 0 || matriz[i, j] == 1)
                            {
                                Console.WriteLine("Esta posição já foi escolhida. Por favor, escolha outra.");
                                posicaoJaEscolhida = true;
                            }
                            else
                            {
                                matriz[i, j] = valor;
                                posicaoJaEscolhida = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Por favor, digite apenas 0 ou 1.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, digite um valor válido (0 ou 1).");
                    }
                } while (posicaoJaEscolhida);
            }
        }

        Console.WriteLine("Matriz resultante:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

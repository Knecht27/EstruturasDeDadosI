using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> tabela = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("Insira o CPF:");
            string cpf = Console.ReadLine();

            if (tabela.ContainsKey(cpf))
            {
                Console.WriteLine("CPF já inserido. Tente novamente.");
                continue;
            }

            Console.WriteLine("Insira o nome:");
            string nome = Console.ReadLine();

            tabela.Add(cpf, nome);

            Console.WriteLine("Dados inseridos com sucesso. Deseja continuar? (s/n)");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() != "s")
            {
                break;
            }
        }

        Console.WriteLine("Exibindo todos os dados inseridos:");
        foreach (KeyValuePair<string, string> item in tabela)
        {
            Console.WriteLine($"CPF: {item.Key}, Nome: {item.Value}");
        }
    }
}

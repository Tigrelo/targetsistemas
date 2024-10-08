using System;

namespace teste
{
    class teste_2
    {
        static void Main(string[] args)
        {
            // Solicita a entrada do usuário
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();

            // Inicializa o contador de ocorrências de 'a' e 'A'
            int count = 0;

            // Percorre cada caractere da string
            foreach (char c in input)
            {
                if (c == 'a' || c == 'A')
                {
                    count++;
                }
            }

            // Verifica se a letra 'a' apareceu e exibe o resultado
            if (count > 0)
            {
                Console.WriteLine($"A letra 'a' aparece {count} vez(es) na string.");
            }
            else
            {
                Console.WriteLine("A letra 'a' não aparece na string.");
            }
        }
    }
}
using System;

namespace teste_1
{
    class test_1
    {
        // Função para verificar se um número está na sequência de Fibonacci
        static bool IsFibonacci(int num)
        {
            int a = 0, b = 1;

            if (num == 0 || num == 1)
            {
                return true;
            }

            while (b <= num)
            {
                if (b == num)
                {
                    return true;
                }
                int temp = b;
                b = a + b;
                a = temp;
            }

            return false;
        }

        static void Main(string[] args)
        {
            // Solicita a entrada do usuário
            Console.Write("Informe um número para verificar se ele pertence à sequência de Fibonacci: ");
            int number = int.Parse(Console.ReadLine());

            // Verifica e exibe o resultado
            if (IsFibonacci(number))
            {
                Console.WriteLine($"O número {number} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {number} NÃO pertence à sequência de Fibonacci.");
            }
        }
    }
}
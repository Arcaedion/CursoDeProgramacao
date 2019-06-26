using System;

namespace GameDevGalaxias
{
    class Program
    {
        static void Main(string[] args)
        {
            // O Primeiro Programa
            Console.Out.WriteLine("Olá mundo!");

            // Declarando Variáveis
            int numeroConta;
            numeroConta = 1;
            double saldo = 500.0;

            // Operações
            saldo -= 100;
            Console.Out.WriteLine("Saldo após transferência: " + saldo);

            Console.ReadLine();
        }
    }
}

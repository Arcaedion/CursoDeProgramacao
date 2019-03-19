using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_Controle
{
    public class Gabarito
    {
        static void Main(string[] args)
        {
            // Exercícios: Estrutura de Controle
            // 1)
            Console.Out.WriteLine("1) ");
            // Resposta: Letra A, pois a condição do IF resulta em "TRUE" (uma vez que o 'saldo' é maior que 'valorTransferencia'
            // E, após entrar no if, saldo é modificado para perder o valorTransferencia. 100.0 - 10.0 = 90.0
            Console.Out.WriteLine("Letra A");
            
            Console.Out.WriteLine("");
            // 2)
            Console.Out.WriteLine("2) ");
            // Letra D, razões similares a anterior
            Console.Out.WriteLine("Letra D");

            Console.Out.WriteLine("");
            // 3)
            Console.Out.WriteLine("3) ");
            // Letra B: Saldo gordinho! A condição do primeiro if resulta em "FALSE" mas a condição do segundo resulta em TRUE, e, portanto, 
            // a mensagem exibida é essa.
            Console.Out.WriteLine("Letra D");

            Console.Out.WriteLine("");
            // 4)
            Console.Out.WriteLine("4) ");
            int idade = 19;
            bool temCarteira = true;
            if(idade >= 18 && temCarteira)
            {
                Console.Out.WriteLine("Apto para conduzir");
            }
            else
            {
                Console.Out.WriteLine("Proíbido dirigir");
            }

            Console.Out.WriteLine("");
            // 5)
            Console.Out.WriteLine("5) ");
            int idade2 = 22;
            string mensagem = idade2 > 18 ? "Idade MAIOR que 18": "Idade MENOR que 18";
            Console.Out.WriteLine(mensagem);


            Console.ReadLine();
        }
    }
}

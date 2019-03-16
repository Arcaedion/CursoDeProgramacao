using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeRepeticao
{
    class Gabarito
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Exercícios");
            Console.Out.WriteLine("1) ");
            Console.Out.WriteLine("Letra D) porque no ciclo for, o valorInvestido está sendo multiplicado por 1, 12 vezes, portanto o valorInvestido não mudará após 12 meses.");
            // Prova:
            double valorInvestido = 3450.0;
            for (int i = 1; i <= 12; i += 1)
            {
                valorInvestido = valorInvestido * 1.00;
            }
            Console.Out.WriteLine("valorInvestido Após 12 meses: " + valorInvestido);

            // --------------------------------
            Console.Out.WriteLine("");
            Console.Out.WriteLine("2)");
            int soma1Ate100 = 0;
            for(int a = 1; a <= 100; a++) // Repare no ++, este operador de incremento adiciona 1 a uma varíavel!
            {
                soma1Ate100 += a;
            }
            Console.Out.WriteLine("A soma dos números de 1 até 100 é: "+ soma1Ate100);

            // --------------------------------
            Console.Out.WriteLine("");
            Console.Out.WriteLine("3) ");
            int val = 10;
            while (val < 25)
            {
                val += 10;
            }
            Console.Out.WriteLine("Letra B: 30.  Após a primeira passagem pelo while, val vai ter o valor 20, e, ");
            Console.Out.WriteLine("como 20 é menor que 25, vai passar de novo. O novo valor agora é 30 e agora não entraremos no for");

            // --------------------------------
            Console.Out.WriteLine("");
            Console.Out.WriteLine("4) ");
            int numero = 2;
            int potencia = 5;
            int resultadoPotencia = 1; ;
            for(int b = 1; b <= 5; b++)
            {
                resultadoPotencia *= numero;
            }
            Console.Out.WriteLine("O resultado é: "+resultadoPotencia);

            // --------------------------------
            Console.Out.WriteLine("");
            Console.Out.WriteLine("5) ");
            // Novo código
            int exercicioIncremento = 10;
            exercicioIncremento++;
            Console.Out.WriteLine("exercicioIncremento: " + exercicioIncremento);

            // --------------------------------
            Console.Out.WriteLine("");
            Console.Out.WriteLine("6) ");
            // Codigo com do while
            int doWhile = 10;
            do
            {
                doWhile += 10;
            } while (doWhile < 5);

            Console.Out.WriteLine("doWhile: " + doWhile);
            Console.Out.WriteLine("Resposta: Não. No código anterior, a variável doWhile seria 10, nesse é 20. ");
            Console.Out.WriteLine("A razão para isso acontecer é que o do...while garante que ao menos uma execução aconteça");
            Console.Out.WriteLine("Independente da condição while.");

            // --------------------------------
            Console.Out.WriteLine("");
            Console.Out.WriteLine("7) ");
            for (int m = 1; m <= 100; m++) // Repare no ++, este operador de incremento adiciona 1 a uma varíavel!
            {
                if(m % 3 == 0)
                    Console.Out.Write(m + ";"); // Write é similar ao WriteLine, com a diferença que ele não pula linhas
            }
            




            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imprimindo um valor 3 vezes manualmente
            int valor = 10;
            Console.Out.WriteLine(valor);
            valor += 1;
            Console.Out.WriteLine(valor);
            valor += 1;
            Console.Out.WriteLine(valor);
            valor += 1;
            Console.Out.WriteLine(valor);


            // Exemplo: Investimento de 1000 reais, cada mês lucra-se 1% desse dinheiro investido.
            // R$ 1000  -> R$ 1126,82
            // 1º mes: 1000 + 1%(1000) = 1010
            // 2º mes: 1010 + 1%(1010) = 1020,10
            // E por aí vai. Quanto teria depois de 12 meses?
            Console.Out.WriteLine("");
            Console.Out.WriteLine("Ciclo for");

            double valorInvestido = 1000.0;
            Console.Out.WriteLine("valorInvestido inicial: " + valorInvestido);
            for (int mes = 1;mes <= 12;mes+=1)
            {
                valorInvestido = valorInvestido * 1.01;
            }
            Console.Out.WriteLine("valorInvestido apos 12 meses: " + valorInvestido);

            Console.Out.WriteLine("");
            Console.Out.WriteLine("Ciclo while");
            double valorInvestido2 = 1000.0;
            Console.Out.WriteLine("valorInvestido2 inicial: " + valorInvestido2);
            int mes2 = 1;
            while (mes2 <= 12)
            {
                valorInvestido2 = valorInvestido2 * 1.01;
                mes2 += 1;
            }
            Console.Out.WriteLine("valorInvestido2 apos 12 meses: " + valorInvestido2);

            Console.Read();
        }
    }
}

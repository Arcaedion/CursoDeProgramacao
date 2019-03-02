using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_Controle
{
    public class EstruturasControle
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Aula 2: Estruturas de Controle");

            double saldo = 500.0;
            double transferencia = 1000.0;

            // && significa "E", em inglês "AND"
            // || significa "OU", em inglês "OR"

            if ( (saldo >= transferencia) && (transferencia > 0) )
            {

                saldo -= transferencia;
                Console.Out.WriteLine("Sucesso!");
            }
            else
            {
                Console.Out.WriteLine("Saldo insuficiente!");
            }

            Console.Out.WriteLine("");
            Console.Out.WriteLine("");

            // Operadores Lógicos
            // Operador &&
            int idade = 18;
            bool temCarteira = false;
            bool podeDirigir = (idade >= 18) && (temCarteira == true);
            Console.Out.WriteLine("Resultado podeDirigir: " + podeDirigir);

            // RESUMO: Resultado apenas é 'VERDADEIRO' se todas as expressões forem verdadeiras.

            // Operador ||
            int idadeCrianca = 13;
            bool estaAcompanhadaDosPais = true;
            bool podeEntrarNaPiscina = (idade >= 15) || (estaAcompanhadaDosPais == true);
            Console.Out.WriteLine("Resultado podeEntrarNaPiscina: " + podeEntrarNaPiscina);

            // RESUMO: Apenas falso se TODAS as expressões forem falsas

            // Operador !
            string cor = "vermelho";
            bool podeEntrarNaFesta = (cor != "verde");
            Console.Out.WriteLine("Resultado podeEntrarNaFesta: " + podeEntrarNaFesta);


            Console.ReadLine();
        }
    }
}

using System;

namespace Gabarito.GameDevGalaxias
{
    class Gabarito
    {
        static void Main(string[] args)
        {
            // Exercício 1
            Console.Out.WriteLine("1)");
            Console.Out.WriteLine("O Guia do GameDev das Galáxias");
            Console.Out.WriteLine(""); // Pula linha

            // Exercício 2
            Console.Out.WriteLine("2)");
            int idadeJoao = 10;
            int idadePedro = 15;
            int idadeMaria = 17;
            double media = (idadeJoao + idadePedro + idadeMaria) / 3;
            Console.Out.WriteLine("A média das idades é: "+ media);
            Console.Out.WriteLine("");

            // Exercício 3
            Console.Out.WriteLine("3)");
            string mensagem = "O Guia do GameDev das Galáxias";
            Console.Out.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}




using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circuferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A area é " + area );
            // Para somar os números entre a mais nessa operação, usar a lógica mátematica dos parenteses,
            //(area +1000) por exemplo

            // Tipos Internos
            bool estaChovendo = true;
            Console.WriteLine("Está Chovendo " + estaChovendo);

            byte idade = 25;
            Console.WriteLine("A idade de fulano é " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O Saldo de Gols é " +saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O Salário é " + salario);

            int menorValorInt = int.MinValue; //Menor valor de Inteiros 
            Console.WriteLine("O menor valor inteiro é " +menorValorInt);

            uint PopulaçaoBrasileira = 207_600_000;
            Console.WriteLine("A população Brasileira é de " +PopulaçaoBrasileira);

            long MenorValorLong = long.MinValue;
            Console.WriteLine("O menor valor de Long é" +MenorValorLong);

            ulong PopulaçaoMundial = 7_600_000_000;
            Console.WriteLine("A pop Mundial é de " +PopulaçaoMundial);

            //Valores Reais 

            float precoComputador = 3000.99f;
            Console.WriteLine("O Preço do Computador é " +precoComputador);

            double ValorDeMercadoDaApple = 1_000_000_000_000.00; //Mais usado nos reais!
            Console.WriteLine("Valor de Mercado da Apple é " +ValorDeMercadoDaApple);

            decimal DistanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("A Distância entre estrelas é " +DistanciaEntreEstrelas);

            //Váriaveis usadas para letras 

            char letra = 'b';
            Console.WriteLine("Letra é " +letra);

            string texto = "Seja Bem Vindo ao Curso de C#!";
            Console.WriteLine(texto);

        }



    }
}

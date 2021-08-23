using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            // Conversão implicita (sem perda de informação)
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            // Conversão explicita (com perda de informação)
            // (int) é um conversor de variaveis 
            double nota = 9.7;
            int NotaTruncada = (int) nota;
            Console.WriteLine("Nota Truncada: {0} ", NotaTruncada);

            // Conversão de string pra número
            Console.WriteLine("Digite sua idade ");
            string IdadeString = Console.ReadLine();
            int IdadeInteiro = int.Parse(IdadeString);
            Console.WriteLine("Idade Inserida: {0}", IdadeInteiro);

            IdadeInteiro = Convert.ToInt32(IdadeString);
            Console.WriteLine("Resultado: {0}", IdadeInteiro);

            /* TryParse é uma tentativa de se fazer um parse, out é necessário para se validar essa tentativa
             * Se não conseguir, o resultado passado será 0
             */
            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado da Tentativa 1 : {0} ", numero);

            Console.Write("Digite o segundo número: ");           
            int.TryParse(Console.ReadLine(), out int numero1);
            Console.WriteLine("Resultado da Tentativa 2 : {0} ", numero1);
        }
    }
}

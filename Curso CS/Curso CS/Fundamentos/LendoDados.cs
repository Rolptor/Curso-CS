using System;
using System.Globalization;
// Globalization "ignora" a pontuação vigente no sistema operacional (virgula em PTBR, ponto em EN)
namespace Curso_CS.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {

            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            // Parse transforma texto em uma string. (Apenas numérico)
            // ReadLine grava a informação no console
            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            /* CultureInfo fornece informação sobre uma cultura em especifico
            * InvariantCulture O objeto é de cultura invariante
            */
            Console.Write("Quanto de salário você recebe? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                   
            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}

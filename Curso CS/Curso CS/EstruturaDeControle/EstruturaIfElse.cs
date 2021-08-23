using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.EstruturaDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();


            Console.Write("Digite a nota do aluno {0}: ", nome);

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 7.0)
            {
                Console.WriteLine("Aluno {0} foi Aprovado", nome);
            }
            else
            {
                Console.WriteLine("Aluno {0} foi Reprovado", nome);
            }
            if (nota >= 9.0)
            {
                Console.WriteLine("O Aluno {0} entrará no quadro de honra", nome);
            }
        }
    }
}

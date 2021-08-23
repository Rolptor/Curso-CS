using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.EstruturaDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de Honras!!");

            } else if (nota>=7.0)
            {
                Console.WriteLine("Aprovado!");

            } else if (nota <=6.9)
            {
                Console.WriteLine("Recuperação");
            }
              else if (nota < 3.0)
            {
                Console.WriteLine("Reprovado");
            }

            Console.WriteLine("Fim");
        }

    }
}

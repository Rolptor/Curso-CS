using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.EstruturaDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {                                       
            // For cria esse laço de repetição, pode-se colocar declaração de variáveis,
            // expressão e operação juntos
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("O valor de I é igual a: {0}", i);
                
            //}

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("A Média da Turma é: {0}", media);

        }
    }
}

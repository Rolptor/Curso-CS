using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool BomComportamento = false;
            string Entrada;
            Console.Write("Digite a nota do aluno: ");
            Entrada = Console.ReadLine();
            Double.TryParse(Entrada, out double nota);

            Console.WriteLine("O Aluno possui bom comportamento (S/N): ");
            Entrada = Console.ReadLine();

            // if (Entrada == "S" || Entrada == "S")
            //     BomComportamento = true;

            // ToLower faz aceitar tanto maiusculo quanto minusculo 
            BomComportamento = Entrada.ToLower() == "s";
            
            // If imprime uma condição verdadeira ou falsa
            if(nota >= 9.0 && BomComportamento)
            {
                Console.WriteLine("Quadro de Honra!!");
            }


        }
    }
}

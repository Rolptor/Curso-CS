using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            // == igualdade = atribuição != diferente
            
            Console.Write("Digite a nota do aluno: ");
            double.TryParse(Console.ReadLine(), out double nota );
            double Media = 7.0;
            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota inválida? {0}", nota < 0);
            Console.WriteLine("Nota perfeita? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota !=10.0);
            Console.WriteLine("Aprovado? {0}", nota >= Media);
            Console.WriteLine("Recuperação? {0}", nota < Media);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.EstruturaDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra = " kk Eae man";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Thiago", "Tai", "Rodrigo" };
            foreach(string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            double nota = 7.0;
            bool bomComportamento = true;
           
            // : significa contrário 
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}

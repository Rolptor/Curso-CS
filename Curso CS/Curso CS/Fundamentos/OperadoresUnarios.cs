using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar() {
            var ValorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-ValorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);

            numero1--;
            Console.WriteLine(numero1);

            /* O Operador (++, --) antes da sintaxe ganha prioridade na validação, 
             * depois da Sintaxe não tem tanta prioridade
             */
            Console.WriteLine(numero1++ == --numero2);
            
        }
    }
}

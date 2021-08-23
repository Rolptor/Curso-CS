using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World").Replace(" World ", "mundo");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string ValorImportante = null;
            Console.WriteLine(ValorImportante?.Length);
        }
    }
}

using System;
using System.Globalization;

namespace Curso_CS.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.375;

            /* F1 = 1 casa decimal
             * C = Currency
             * P = Percentual
             * #.## = F2 (2 casas decimais)
         */
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", cultura));

            // D completa até ficar em X casas decimais 
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}

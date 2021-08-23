using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.Fundamentos
{
    class Inferência
    {
        public static void Executar()
        {
            var nome = "Thiago";
            //nome = 123;
            Console.WriteLine(nome);

            //int = idade;
            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;
            // Aplicando Lógica Matemática 
            Console.WriteLine("Soma de A+B é igual a " + (a + b));
        }
    }
}

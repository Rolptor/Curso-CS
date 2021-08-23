using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa pessoinha = new Pessoa();
            pessoinha.Nome = "Thiago";
            pessoinha.Idade = 22;

           
            pessoinha.ApresentarNoConsole();

        }
    }
}

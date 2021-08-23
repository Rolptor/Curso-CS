using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            // Format faz o mesmo que CW mas formatado
            return string.Format($"Olá me chamo {Nome} e tenho {Idade} anos de idade.");
        }
        
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }

}

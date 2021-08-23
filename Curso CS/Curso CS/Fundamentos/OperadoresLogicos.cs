using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            bool TrabalhoTerca = false;
            bool TrabalhoQuinta = false;
            /*
             * && E
             * || OU
             * ^ Ou exclusivo 
             * ! Negação lógica (operador unário) 
             * */

            bool TV50 = TrabalhoTerca && TrabalhoQuinta;
            Console.WriteLine($"Comprou TV de 50 polegadas {TV50}");

            var sorvete = TrabalhoTerca || TrabalhoQuinta;
            Console.WriteLine("Comprou Sorvete {0}", sorvete);

            var TV32 = TrabalhoTerca ^ TrabalhoQuinta;
            Console.WriteLine($"Comprou a TV de 32 polegadas? {TV32} ");
            
            
            Console.WriteLine("Foi mais saudável? {0}", !sorvete );

        
        
        }

    }
}

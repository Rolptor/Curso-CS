using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.EstruturaDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("Por favor avalie o atendimento de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            //Switch pode imprimir números inteiros
            switch (nota)
            {
                // break quebra essa sentença e faz com que o código vá pra sentença posterior
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Ok");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    break;
              // default é usado quando nenhum dos números válidos é inserido.
                default:
                    Console.WriteLine("Nota inválida");
                    break;


            }
            Console.WriteLine("Fim");
        }
    }
}

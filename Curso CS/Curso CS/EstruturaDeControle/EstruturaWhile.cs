using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();


            // Next ira gerar um valor entre o intervalo de 1 e 15
            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0; 

            // Enquanto as tentativas restantes forem maior que zero, mas o número não ser o certo
            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira seu Palpite: ");
                string Entrada = Console.ReadLine();
                int.TryParse(Entrada, out palpite);

                    // Tentativas aumentam, e as restantes diminuem
                tentativas++;
                tentativasRestantes--;

                    // Caso o jogador acerte o número
                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                
                    // caso o palpite for maior que o número
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Tente um número mais baixo...");
                    Console.WriteLine("Tentativas Restantes {0}", tentativasRestantes);
                
                    // caso for menor que o número
                } else
                {
                    Console.WriteLine("Tente um número mais alto... ");
                    Console.WriteLine("Tentativas Restantes {0}", tentativasRestantes);
                }

            }
           
        }
    }
}

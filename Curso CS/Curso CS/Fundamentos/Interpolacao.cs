using System;

namespace Curso_CS.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            // Não esquecer do sinal da concatenação "+" ou ","
            Console.WriteLine("O " + nome + " da marca "
                + marca + " custa " + preco + ".");
            Console.WriteLine("O {0} da marca {1} custa {2}", nome, marca, preco);
            Console.WriteLine($"O {nome} da marca {marca} custa {preco}");
            Console.WriteLine($"1 + 1 =  {1 + 1}");

        }
    }
}

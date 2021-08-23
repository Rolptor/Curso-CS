using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço com Desconto
            var preco = 1000;
            var imposto = 355.5;
            var desconto = 0.1;

            double total = preco + imposto;
            double Descontototal = total - (total * desconto);
            Console.WriteLine(" O preço do produto é de R${0}", Descontototal);

            // IMC
            // Math.Pow eleva o numero a potência
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"O seu IMC é: {imc}.");

            // Par e Impar 
            // % (módulo) é o resto da divisão 
            int par = 20;
            int impar = 57;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar %2 );
            
        }
    }
}

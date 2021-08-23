using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.ClassesEMetodos
{
    class CalculadoraComum
    {

        // Retorno Int necessita de um return
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            // This é a instância atual que se está trabalhando 
            return this;

        }
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;

            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
        class MetodosComRetorno
        {
            public static void Executar()
            {

                var CalculadoraComum = new CalculadoraComum();
                var resultado = CalculadoraComum.Somar(5, 5);

                Console.WriteLine(resultado);
                Console.WriteLine(CalculadoraComum.Subtrair(2, 7));
                Console.WriteLine(CalculadoraComum.Multiplicar(5, 5));

                var CalculadoraCadeia = new CalculadoraCadeia();
                CalculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();


            }
        }
    }
}
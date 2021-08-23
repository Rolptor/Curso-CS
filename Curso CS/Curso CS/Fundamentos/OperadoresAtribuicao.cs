using System;

namespace Curso_CS.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
             num1 = 7;
            num1 += 10;    //num1 = num1+ 10
            num1 -= 3;    // num 1 = num1 - 3
            num1 *= 5;   //  num 1  =  num1 * 5
            num1 /= 2;  //   num 1  = num 1 /2

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1 (Operador de Incremento)
            b--; // b = b - 1 (Operador de Decremento)

            Console.WriteLine($"{a}, {b}");


            // Não se preocupar com o código abaixo
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "Thiago";

            dynamic d = c;
            d.nome = "Tainara";
           
            Console.WriteLine(c.nome);

                
        }
    }
}

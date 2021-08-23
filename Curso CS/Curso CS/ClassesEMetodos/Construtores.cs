using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.ClassesEMetodos
{
    class Carro
    {
        public string Fabricante;
        public string Modelo;
        public int Ano;

        public Carro(string fabricante, string modelo, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro()
        {

        }
            
    }
    class Construtores
    {
        public static void Executar()
        {
            var Carro1 = new Carro();
            Carro1.Fabricante = "Mercedes";
            Carro1.Modelo = "SL-500";
            Carro1.Ano = 2021;
            Console.WriteLine("{0}, {1}, {2}", Carro1.Fabricante, Carro1.Modelo, Carro1.Ano);

            var Carro2 = new Carro("Ferrari", "Spider", 2021);
            Console.WriteLine($"{Carro2.Fabricante}, {Carro2.Modelo}, {Carro2.Ano}");

           
            
        }
    }
}

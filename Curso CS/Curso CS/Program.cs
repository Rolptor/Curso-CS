using System;
using System.Collections.Generic;

using Curso_CS.Fundamentos;
using Curso_CS.EstruturaDeControle;
using Curso_CS.ClassesEMetodos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(NewMethod());

            central.SelecionarEExecutar();
        }

        private static Dictionary<string, Action> NewMethod()
        {
            return new Dictionary<string, Action>() {
               
                // Fundamentos 
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferência.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados do Console - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões- Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle 
                {"Estrutura If - Estruturas de Controle ", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle ", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de Controle ", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle ", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle ", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle ", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle ", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle ", EstruturaForeach.Executar},
                {"Usando Break - Estruturas de Controle ", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle ", UsandoContinue.Executar},

                // Classes e Métodos
                {"Membros - Classes e Metodos ", Membros.Executar},
                {"Construtores - Classes e Metodos ", Construtores.Executar},
                {"Metodos com Retorno - Classes e Metodos ", MetodosComRetorno.Executar},
                
                






















            };
        }
    }

    internal class MetodosComRetorno
    {
        internal static void Executar()
        {
            throw new NotImplementedException();
        }
    }
}
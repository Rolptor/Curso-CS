﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS.EstruturaDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.Write("Numeros pares entre 1 e {0} são: ", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            

        }
    }
}
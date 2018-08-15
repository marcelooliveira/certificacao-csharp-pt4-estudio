﻿using System;
using System.Text.RegularExpressions;

namespace _04.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFatorial(5);
            GetFatorial(4);
            GetFatorial(3);
            GetFatorial(2);
            GetFatorial(1);
            GetFatorial(0);

            //RelatorioClientes.ImprimirListagemClientes();

            //MenuCaixaEletronico menu = new MenuCaixaEletronico();
            //menu.Executar();
        }

        private static int GetFatorial(int numero)
        {
            //FATORIAL DE 5 = 5 x 4 x 3 x 2 x 1  = 120
            //FATORIAL DE 4 = 4 x 3 x 2 x 1      = 24
            //FATORIAL DE 3 = 3 x 2 x 1          = 6
            //FATORIAL DE 2 = 2 x 1              = 2 
            //FATORIAL DE 1                      = 1
            //FATORIAL DE 0                      = 1 

            int fatorial = 1;
            //int fator = numero; //inicializacao

            //while (fator >= 1) //condicao
            //{
            //    fatorial = fatorial * fator;
            //    fator = fator - 1; //decremento
            //}

            for (int fator = numero; fator >= 1; fator--)
            {
                fatorial *= fator;
            }


            System.Console.WriteLine($"fatorial de {numero} é {fatorial}");

            return fatorial;
        }
    }
}

﻿using System;
using System.Text.RegularExpressions;

namespace _01.ByteBank
{
    class Program
    {
        delegate void ItemMenu();

        static void Main(string[] args)
        {
            
        }

        private static void ExibirMenu()
        {
            var itensMenu = new ItemMenu[]
            {
                TestesContaBancaria,
                TestesEmprestimo
            };

            int opcao = 0;
            do
            {
                Console.Clear();
                for (int i = 0; i < itensMenu.Length; i++)
                {
                    string name = itensMenu[i].Method.Name;
                    var descricao = Regex.Replace(name, "([A-Z]{1,2}|[0-9]+)", " $1").TrimStart();
                    Console.WriteLine($"{i + 1} - {descricao}");
                }
                Console.WriteLine($"0 - Sair");
                Console.WriteLine();
                Console.Write("Digite uma opção: ");
                string input = Console.ReadLine();
                int.TryParse(input, out opcao);
                if (opcao > 0)
                {
                    Console.Clear();
                    itensMenu[opcao - 1]();
                    Console.Write("Tecle algo para continuar... ");
                    Console.ReadKey();
                }
            }
            while (opcao != 0);

        }

        private static void TestesContaBancaria()
        {
            ContaBancaria conta = new ContaBancaria(100);

            ///conta.SacarDinheiro(15m);
            ///conta.SacarDinheiro(350);
        }

        private static void TestesEmprestimo()
        {
            Emprestimo emprestimo1 = new Emprestimo("A1234");
            ///Emprestimo emprestimo2 = new Emprestimo("xyz");
            ///emprestimo2.RedefinirCodigoContrato("BC2345");
            ///emprestimo2.Prazo = 3;
            ///emprestimo2.Prazo = 7;
            ///emprestimo2.CalcularJuros(6000, 3);
            ///emprestimo2.CalcularJuros(8500, 6);
            ///emprestimo2.CalcularJuros(11500, 4);
        }

    }
}

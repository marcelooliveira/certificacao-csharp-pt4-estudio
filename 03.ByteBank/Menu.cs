using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.ByteBank
{
    class Menu
    {
        delegate void ItemMenu();
        public void Executar()
        {
            var itensMenu = new ItemMenu[]
            {
                IfElse,
                CompilacaoCondicional,
                WhileDo,
                ForEForeach,
                SwitchCaseDefault,
                TryCatch
            };

            int opcao = -1;
            while (opcao != 0)
            {
                opcao = GerarMenu(itensMenu);
            }
        }

        private static int GerarMenu(ItemMenu[] itensMenu)
        {
            ImprimirMenu(itensMenu);
            return GetOpcao(itensMenu);
        }

        private static int GetOpcao(ItemMenu[] itensMenu)
        {
            Console.Write("Digite uma opção: ");
            string input = Console.ReadLine();
            int.TryParse(input, out int opcao);
            if (opcao > 0)
            {
                itensMenu[opcao - 1]();
            }
            Console.WriteLine();
            Console.WriteLine("Digite algo para continuar...");
            Console.ReadKey();
            return opcao;
        }

        private static void ImprimirMenu(ItemMenu[] itensMenu)
        {
            for (int i = 0; i < itensMenu.Length; i++)
            {
                string name = itensMenu[i].Method.Name;
                var descricao = Regex.Replace(name, "([A-Z]{1,2}|[0-9]+)", " $1").TrimStart();
                Console.WriteLine($"{i + 1} - {descricao}");
            }
            Console.WriteLine($"0 - Sair");
            Console.WriteLine();
        }

        private void TryCatch()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

        private void SwitchCaseDefault()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

        private void ForEForeach()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

        private void WhileDo()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

        private void IfElse()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

        private void CompilacaoCondicional()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }
    }
}

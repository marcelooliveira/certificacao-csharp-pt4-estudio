using System;
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

        private static void IfSemElse()
        {
            // instrução if sem um else  
            bool condicao = true;
            if (condicao)
            {
                //instrução then;
                FacaAlgo();
            }
            // Próxima instrução do programa. 
        }

        private static void IfElse()
        {
            bool condicao = true;

            if (condicao)
            {
                Console.WriteLine(
                    "A expressão foi avaliada como verdadeiro.");
            }
            else
            {
                Console.WriteLine(
                    "A expressão foi avaliada como falso.");
            }
        }

        private static void IfAninhado()
        {
            int m = 12;
            int n = 18;

            if (m > 10)
                if (n > 20)
                {
                    Console.WriteLine("Resultado 1");
                }
                else
                {
                    Console.WriteLine("Resultado 2");
                }

            if (m > 10)
            {
                if (n > 20)
                    Console.WriteLine("Result1");
            }
            else
            {
                Console.WriteLine("Result2");
            }
        }

        private static void IfTesteCaracteres()
        {
            Console.Write("Digite um caractere: ");
            char c = (char)Console.Read();
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("O caractere é minúsculo.");
                }
                else
                {
                    Console.WriteLine("O caractere é maiúsculo.");
                }
            }
            else
            {
                Console.WriteLine("O caractere não é alfabético.");
            }
        }

        private static void IfTesteConsoleRead()
        {
            Console.Write("Digite um caractere: ");
            char ch = (char)Console.Read();

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("O caractere é maiúsculo.");
            }
            else if (Char.IsLower(ch))
            {
                Console.WriteLine("O caractere é minúsculo.");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("O caractere é um número.");
            }
            else
            {
                Console.WriteLine("O caractere não é alfanumérico.");
            }
        }

        private static void IfNot()
        {
            bool resultado = true;
            if (!resultado)
            {
                Console.WriteLine(
                    "A condição é verdadeira (resultado é falso).");
            }
            else
            {
                Console.WriteLine(
                    "A condição é falsa (resultado é verdadeiro).");
            }
        }

        private static void IfAndOr()
        {
            int m0 = 9;
            int n0 = 7;
            if (m0 >= n0)
            {
                Console.WriteLine("m0 é maior ou igual a n0.");
            }
            
            // AND curto-circuito
            int m1 = 9;
            int n1 = 7;
            int p1 = 5;
            if (m1 >= n1 && m1 >= p1)
            {
                Console.WriteLine("Nada é maior que m1.");
            }

            // AND e NOT
            if (m1 >= n1 && !(p1 > m1))
            {
                Console.WriteLine("Nada é maior que m1.");
            }

            // OR curto-circuito
            if (m1 > n1 || m1 > p1)
            {
                Console.WriteLine("m não é o menor.");
            }

            // NOT e OR  
            m1 = 4;
            if (!(m1 >= n1 || m1 >= p1))
            {
                Console.WriteLine("agora me é o menor.");
            }
        }

        private static void OperadoresRelacionais()
        {
            dynamic x = 10;
            dynamic y = 23;

            if (x == y)
                Console.WriteLine("x igual a y");
            if (x != y)
                Console.WriteLine("x diferente de y");
            if (x < y)
                Console.WriteLine("menor que(verdadeiro se x for menor que y)");
            if (x > y)
                Console.WriteLine("maior que(verdadeiro se x for maior que y)");
            if (x <= y)
                Console.WriteLine("menor ou igual a");
            if (x >= y)
                Console.WriteLine("maior que ou igual a");
        }

        private static void OperadoresTesteTipo()
        {
            dynamic x = 10m;

            if (x is int)
                Console.WriteLine("x é int");
            if (x is long)
                Console.WriteLine("x é long");
            if (x is decimal)
                Console.WriteLine("x é decimal");
        }

        private static void FacaAlgo()
        {
            Console.WriteLine("Fazendo algo...");
        }

        private static void IfThenElseIfElse()
        {
            bool valor = true;

            if (valor)
            {
                Console.WriteLine("bloco then");
            }
            else if (valor)
            {
                Console.WriteLine("else if");
            }
            else if (valor)
            {
                Console.WriteLine("else if 2");
            }
            else
            {
                Console.WriteLine("else");
            }
        }
    }
}

//943-redeswifi-video1.1-Introdu‡Æo.trec
//943-redeswifi-video1.2-conhecendo a rede.trec
//943-redeswifi-video1.3-entendendo os padroes de wifi.trec
//943-redeswifi-video2.1-colocando um novo departamento.trec
//943-redeswifi-video2.2-alterando o canal do wifi.trec
//943-redeswifi-video2.3-o que atrapalha o sinal do wifi.trec
//943-redeswifi-video3.1-conhecendo o wep.trec
//943-redeswifi-video3.2-conhecendo o wpa e wpa2.trec
//943-redeswifi-video3.3-conhecendo os problemas de seguran‡a de uma rede sem fio.trec
//943-redeswifi-video4.1-conhecendo o roteador sem fio.trec
//943-redeswifi-video4.2-ConclusÆo.trec

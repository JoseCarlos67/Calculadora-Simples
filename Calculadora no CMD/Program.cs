using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_no_CMD
{
    internal class Program
    {

        //Enum com as opções da calculadora
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair = 0 }

        static void Main(string[] args) //Início do método main
        {

            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo ao CALC! Escolha uma das opções abaixo:");
                Console.WriteLine("\n1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n0-Sair\n");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;

                }

            }
            //Console.ReadKey();

        }// Fim do método main

        //Funções
        static void Soma()
        {
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadKey();
            Console.Clear();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração entre dois números");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para ao menu.");
            Console.ReadLine();
            Console.Clear();
        }

        static void Divisao()
        {
            bool verifica = false;

            Console.WriteLine("Divisão entre dois números");
            Console.WriteLine("Informe o valor do Dividendo: ");
            int a = int.Parse(Console.ReadLine());
            
            while (!verifica)
            {
                Console.WriteLine("Informe o valor do Divisor: ");
                int b = int.Parse(Console.ReadLine());

                if (b == 0)
                {
                    Console.WriteLine("O dividor não pode ser 0! Informe um outro valor.");
                } 
                else
                {
                    float result = (float)a / (float)b;
                    Console.WriteLine($"Resultado: {result}");
                    verifica = true;
                }
            }
            Console.WriteLine("Aperte ENTER para voltar para ao menu.");
            Console.ReadKey();
            Console.Clear();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de entre dois números");
            Console.WriteLine("Digite o primero número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadKey();
            Console.Clear();
        }

        static void Potencia()
        {
            Console.WriteLine("Potência de um número");
            Console.WriteLine("Digite a Base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expoente);
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadKey();
            Console.Clear();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um número");
            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Sqrt(a);
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadKey();
            Console.Clear();
        }

    }// Fim da classe interna Program

}

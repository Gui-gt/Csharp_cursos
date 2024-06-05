using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtração, Divisão,Multiplicação, Potencia, Raiz, Sair };
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while(!escolheuSair) // ! ele inverte a lógica, fazendo false virar true e vice e versa;
            {
                Console.WriteLine("Bem vindo a Calculadora, selecione uma das opções: ");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair");

                /*string opcaoTXT = Console.ReadLine();   
                int opcaoN = int.Parse(opcaoTXT);
                Menu opcao = (Menu)opcaoN;*/
                                                                                //exibe menu    
                Menu Opcao = (Menu)int.Parse(Console.ReadLine());

                Console.WriteLine(Opcao);
                Console.Clear();

                switch(Opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;


                    case Menu.Subtração:
                        Subtração(); 
                        break;

                    case Menu.Divisão:
                        Divisão(); 
                        break;   

                        case Menu.Multiplicação:
                        Multiplicação();   
                        break;

                        case Menu.Potencia:
                            Potencia();
                            break;

                        case Menu.Raiz:
                            Raiz(); 
                            break;


                    case Menu.Sair:
                        escolheuSair |= true;
                        break;
                }
            }
            //fecha menu
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números:");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Subtração()
        {
            Console.WriteLine("Subtração de dois números:");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Divisão()
        {
            Console.WriteLine("Divisão de dois números:");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Multiplicação()
        {
            Console.WriteLine("Multiplicação de dois números:");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            float resultado = a * b;
            Console.WriteLine($"O resultado: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Potência de dois números:");
            Console.WriteLine("Digite o número base:");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número expoente:");
            int expo = int.Parse(Console.ReadLine());
            int resultado =(int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz do número:");
            Console.WriteLine("Digite o número:");
            int a = int.Parse(Console.ReadLine());
            double resultado = (double)Math.Sqrt(a);
            Console.WriteLine($"O resultado: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
    }
}

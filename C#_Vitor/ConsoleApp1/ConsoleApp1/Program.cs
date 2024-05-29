using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int = 8
            //float = 8.8f
            //string = "texto"
            //char = caracter = 'G'

            //const = valor que jamais muda
            //var = jeito preguiçoso de atribuir valores

            // C# pode fazer qualquer coisa, Jogos, aplicações desktop, sistemas web e muito mais.
            // .NET ou dotNet é uma plataforma que contém todos os módulos da linguagem, pois se não sobrecarregaria o código
            //using ( "usando uma módulo ou biblioteca C#, para certo fim")
            //existem várias bibliotecas com várias finalidades
            //.NET só é para Windows

            /*int numeroQualquer = 20 + 20 - 80;
            int numeroDiv = 6 / 2;
            float numeroX = 5.0f / 2;


            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroDiv);
            Console.WriteLine(numeroX);*/

            //Ordem de precedência
            /*Primeiro * (MULTIPLICAÇÃO) e / (DIVISÃO)
            Depois + e -, Porém se ouver (), a ordem mudo e começa por eles.
            Exemplo:

            n = 2 + 2 * 10 = 22 sem parentêses
            n = (2 + 2) * 10 = 40 com () */

            //Operadores Aritméticos

            //> < = == >= <= !=

            //Operadores Lógicos

            //(AND e OR) && ||

            /*int n = 2 + 2 * 10;
              int num = (2 + 2) * 10;

            Console.WriteLine(n);
            Console.WriteLine(num);*/

            //Condicionais em C#

            /* Console.WriteLine("Digite sua idade");
             int idade = int.Parse(Console.ReadLine());    

             if(idade >= 0 && idade <= 11)
             {
                 Console.WriteLine("Voçê é uma criança");
             }else if(idade  >= 11 && idade <= 18)
             {
                 Console.WriteLine("Voçê é um adolescente");
             }else if(idade >= 19 && idade <= 60)
             {
                 Console.WriteLine("Voçê é um adulto");
             }else
             {
                 Console.WriteLine("Voçê é um idoso");
             }*/


            //Funçôes em C#

            // Uma função é um método que pode ser chamado no método principal (MAIN):
            //Por exemplo:

            /*static void Main()
            {
                Guilherme(); // Aqui será impresso o que está dentro da função Guilherme 
            }



            static void Guilherme ()
            {
                Console.WriteLine("Seja Bem vindo");
                Console.WriteLine("Estou aprendendo c#");
                Console.WriteLine("que curso show de bola");
            }*/

            GerarProduto(-20, "Curso de Node JS");
            

            Console.ReadLine();               
        }   
        
        static void GerarProduto(int preco, string nome)
        {
            int precoAbs = Math.Abs(preco);
            int precoFinal = precoAbs + (precoAbs * 2);
            Console.WriteLine("Nome do Produto: " + nome);
            Console.WriteLine("Valor do produto: " + precoFinal);
        }
    }                                         
}

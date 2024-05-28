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
            string nome;
            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é {0}?", nome);
            if(nome == "Guilherme")
            {
                Console.WriteLine("Prazer em te conhecer então");
            }
            else if(nome != "Guilherme")
            {
                Console.WriteLine("Desculpe o incômodo então");
            }
            Console.ReadLine();
        }
    }
}

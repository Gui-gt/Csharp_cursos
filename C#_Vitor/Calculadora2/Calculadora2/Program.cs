using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtração, Multiplição, Divisão, Potencia }
        static void Main(string[] args)
        {
            Console.WriteLine("<<< CALCULADORA >>>");
            Console.WriteLine("escolha uma opção abaixo:");
            Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n5-Potencia");
            

            Console.ReadLine();
        }
    }
}

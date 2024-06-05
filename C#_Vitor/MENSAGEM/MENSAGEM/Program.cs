using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENSAGEM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char escolha;
            Console.WriteLine("A gente vai almoçar em casa?");
            Console.WriteLine("S / N ?");
            escolha = char.Parse(Console.ReadLine());
            if(escolha == 's' || escolha == 'S')
            {
                Console.WriteLine("Então se arruma mo");
            }
            else if(escolha == 'N' || escolha == 'n')
            {
                Console.WriteLine("beleza Giovana");
            }
            Console.ReadLine();
        }
    }
}

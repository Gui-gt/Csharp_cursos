using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Program
    {

            struct Produto{
            public float peso;
            public float altura;
            public string nome;
            public string marca;
            }
        static void Main(string[] args)
        {
            Produto bola = new Produto();
            bola.nome = "Bola do Ronaldinho";
            bola.peso = 14f;
            bola.altura = 1f;
            bola.marca = "Nike";

            Produto balde = new Produto(){
                balde.nome = "Balde";
                balde.altura = "2f"
                balde.peso = "1f";
                balde.marca = "Tramontina";
            }


            Console.WriteLine(bola.nome);
            Console.WriteLine(balde.marca);
            Console.readLine();
        }
    }
}

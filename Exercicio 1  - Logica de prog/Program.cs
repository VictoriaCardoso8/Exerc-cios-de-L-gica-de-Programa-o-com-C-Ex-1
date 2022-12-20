//Implemente um programa que:

//1) leia a tabela acima em um array bidimensional. O programa não deve perguntar distâncias já informadas (por exemplo, se o usuário já forneceu a distância entre 1 e 3 não é necessário informar a distância entre 3 e 1, que é a mesma) e também não deve perguntar a distância entre uma cidade e ela mesma, que é sempre 0;

//2) leia um percurso fornecido pelo usuário e armazene em um array unidimensional.

//Após isso, calcule e mostre a distância percorrida pelo usuário. Por exemplo, para o percurso 1, 2, 3, 2, 5, a, 4 teremos 15 + 10 + 10+ 28 + 12 +5 = 80 km.

//Crie um repositório público no GitHub e submeta o link para o seu repositório.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Prova
    {
        static void Main(string[] args)
        {
            int[,] DistanciaCidades = new int[,] { {00, 15, 30, 05, 12 },
                                                   {15, 00, 10, 17, 28 },
                                                   {30, 10, 00, 03, 11 },
                                                   {05, 17, 03, 00, 80 },
                                                   {12, 28, 11, 80, 00 } };

            int n = new int();
            int DistanciaTotal = 0;
            Stack<int> cidades = new Stack<int>();
            int contador = 0;
            string caminho;
            Console.WriteLine("Informe as cidades, separadas apenas por virgula:");
            caminho = Console.ReadLine();

            int[] numeros = caminho.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();

            for (int i = 0; i < numeros.Length - 1; i++)
            {
                int cidade1 = numeros[i];
                int cidade2 = numeros[i + 1];
                DistanciaTotal += DistanciaCidades[cidade2 - 1, cidade1 - 1];
            }
            Console.WriteLine("A distancia total será: " + DistanciaTotal);
        }
    }
}




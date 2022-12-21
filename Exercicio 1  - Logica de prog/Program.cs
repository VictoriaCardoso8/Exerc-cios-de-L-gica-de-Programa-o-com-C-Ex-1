//Implemente um programa que:

//1) leia a tabela acima em um array bidimensional. O programa não deve perguntar distâncias já informadas (por exemplo, se o usuário já forneceu a distância entre 1 e 3 não é necessário informar a distância entre 3 e 1, que é a mesma) e também não deve perguntar a distância entre uma cidade e ela mesma, que é sempre 0;

//2) leia um percurso fornecido pelo usuário e armazene em um array unidimensional.

//Após isso, calcule e mostre a distância percorrida pelo usuário. Por exemplo, para o percurso 1, 2, 3, 2, 5, a, 4 teremos 15 + 10 + 10+ 28 + 12 +5 = 80 km.

//Crie um repositório público no GitHub e submeta o link para o seu repositório.


using Exercicio_1____Logica_de_prog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Prova
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Informe o numero de cidades:");
            //var NumCidades = Console.ReadLine().ToInt();
            //var  TabelaDistancia = new int[NumCidades, NumCidades];

            //for (int i = 0; i < NumCidades; i++)
            //{
            //    for (int j = i+1; j < NumCidades; j++)
            //    {
            //        Console.WriteLine($"Informe a distância entre a cidade {i+1} e a cidade {j+1}");
            //        TabelaDistancia[i,j] = TabelaDistancia[j, i] = Console.ReadLine().ToInt();
            //    }
            //}
            string diretorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string diretoriomatriz = diretorio + "\\matriz.txt";
            string[] lines = System.IO.File.ReadAllLines(diretoriomatriz);
            int NumCidades = lines.Length;
            var TabelaDistancia = new int[NumCidades, NumCidades];
            string diretoriocaminho = diretorio + "\\caminho.txt";
            string[] caminho = System.IO.File.ReadAllLines(diretoriocaminho);

            for (int i = 0; i < NumCidades; i++)
            {
                var coluna = lines[i].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for(int j=0; j < NumCidades; j++)
                {
                    TabelaDistancia[i,j] = coluna[j];
                }
            }

            int[] numeros = caminho[0].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();


            int n = new int();
            int DistanciaTotal = 0;
            Stack<int> cidades = new Stack<int>();
            int contador = 0;

            for (int i = 0; i < numeros.Length - 1; i++)
            {
                int cidade1 = numeros[i];
                int cidade2 = numeros[i + 1];
                DistanciaTotal += TabelaDistancia[cidade2 - 1, cidade1 - 1];
            }
            Console.WriteLine("A distancia total será: " + DistanciaTotal);
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votacao_Personagens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, maisVotado = 0, menosVotado = 0, nulos, votosTotal = 100;
            int[] votos = new int[5];


            for (int i = 0; i < votosTotal; i++)
            {
                Console.WriteLine("0. Perna Longa\n1. Pluto\n2. Mickey\n3. Bob Esponja\n4. Cebolinha");
                opcao = int.Parse(Console.ReadLine());

                if (opcao >= 0 && opcao <= 4)
                {
                    votos[opcao]++;
                }

                else
                {
                    Console.WriteLine("Voto nulo");
                }

            }

            for (int i = 1; i < votosTotal; i++)
            {
                if (votos[i] > votos[maisVotado])
                {
                    maisVotado = i;
                }

                if (votos[i] < votos[menosVotado])
                {
                    menosVotado = i;
                }
            }

            Console.WriteLine("Candidato mais votado: {0}. Votos: {1}", maisVotado, votos[maisVotado]);
            Console.WriteLine("Candidato menos votado: {0}. Votos: {1}", menosVotado, votos[menosVotado]);

            nulos = votosTotal - votos[0] - votos[1] - votos[2] - votos[3] - votos[4];
            Console.WriteLine($"Votos nulos: {nulos}");

            Console.ReadKey();
        }
    }
}

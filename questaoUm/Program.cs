using System;
using System.Collections.Generic;
using System.Linq;

namespace questaoUm
{
    class Program
    {
        static void Main(string[] args, double[] ranking)
        {
            List<Atleta> atletas = new List<Atleta>();
            atletas.Add(new Atleta("x","x", 0));
            atletas.Add(new Atleta("x","x", 0));
            atletas.Add(new Atleta("x","x", 0));
            atletas.Add(new Atleta("x","x", 0));
            atletas.Add(new Atleta("x","x", 0));
            atletas.Add(new Atleta("x","x", 0));
            atletas.Add(new Atleta("x","x", 0));
            atletas.Add(new Atleta("x","x", 0));
            atletas.Add(new Atleta("x","x", 0));
            atletas.Add(new Atleta("x","x", 0));

            Console.WriteLine("Atletas:");
            Console.WriteLine("");

            Console.WriteLine("Digite o NOME do atleta 1: ");
            atletas[0].Nome = Console.ReadLine();
            Console.WriteLine("Digite o PAÍS do atleta 1: ");
            atletas[0].Pais = Console.ReadLine();
            Console.WriteLine("Digite o RESULTADO (em metros) do atleta 1: ");
            atletas[0].Distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o NOME do atleta 2: ");
            atletas[1].Nome = Console.ReadLine();
            Console.WriteLine("Digite o PAÍS do atleta 2: ");
            atletas[1].Pais = Console.ReadLine();
            Console.WriteLine("Digite o RESULTADO (em metros) do atleta 2: ");
            atletas[1].Distancia = Convert.ToDouble(Console.ReadLine());

            double[] posicoes = new double[2];
            
            for(int i=0; i < atletas.Count; i++)
            {
                posicoes[i] = atletas[i].Distancia;
            }

            Array.Sort(posicoes); 

            double primeiro = posicoes[0];
            double segundo = posicoes[1];
            double terceiro = posicoes[2];

            // var podium = atletas.GroupBy(atletas => atletas.Distancia);    
            // foreach(var group in atletas)
            // {
            //     if(primeiro = Distancia)
                
            //     Console.WriteLine(group.Key + ": " + group.Count());
            // }     
            
    }
}

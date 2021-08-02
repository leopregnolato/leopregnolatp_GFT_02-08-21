using System;
using System.Collections.Generic;
using System.Linq;

namespace questaoUm
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("Digite o NOME do atleta 3: ");
            atletas[2].Nome = Console.ReadLine();
            Console.WriteLine("Digite o PAÍS do atleta 3: ");
            atletas[2].Pais = Console.ReadLine();
            Console.WriteLine("Digite o RESULTADO (em metros) do atleta 3: ");
            atletas[2].Distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o NOME do atleta 4: ");
            atletas[3].Nome = Console.ReadLine();
            Console.WriteLine("Digite o PAÍS do atleta 4: ");
            atletas[3].Pais = Console.ReadLine();
            Console.WriteLine("Digite o RESULTADO (em metros) do atleta 4: ");
            atletas[3].Distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o NOME do atleta 5: ");
            atletas[4].Nome = Console.ReadLine();
            Console.WriteLine("Digite o PAÍS do atleta 5: ");
            atletas[4].Pais = Console.ReadLine();
            Console.WriteLine("Digite o RESULTADO (em metros) do atleta 5: ");
            atletas[4].Distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o NOME do atleta 6: ");
            atletas[5].Nome = Console.ReadLine();
            Console.WriteLine("Digite o PAÍS do atleta 6: ");
            atletas[5].Pais = Console.ReadLine();
            Console.WriteLine("Digite o RESULTADO (em metros) do atleta 6: ");
            atletas[5].Distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o NOME do atleta 7: ");
            atletas[6].Nome = Console.ReadLine();
            Console.WriteLine("Digite o PAÍS do atleta 7: ");
            atletas[6].Pais = Console.ReadLine();
            Console.WriteLine("Digite o RESULTADO (em metros) do atleta 7: ");
            atletas[6].Distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o NOME do atleta 8: ");
            atletas[7].Nome = Console.ReadLine();
            Console.WriteLine("Digite o PAÍS do atleta 8: ");
            atletas[7].Pais = Console.ReadLine();
            Console.WriteLine("Digite o RESULTADO (em metros) do atleta 8: ");
            atletas[7].Distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o NOME do atleta 9: ");
            atletas[8].Nome = Console.ReadLine();
            Console.WriteLine("Digite o PAÍS do atleta 9: ");
            atletas[8].Pais = Console.ReadLine();
            Console.WriteLine("Digite o RESULTADO (em metros) do atleta 9: ");
            atletas[8].Distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o NOME do atleta 10: ");
            atletas[9].Nome = Console.ReadLine();
            Console.WriteLine("Digite o PAÍS do atleta 10: ");
            atletas[9].Pais = Console.ReadLine();
            Console.WriteLine("Digite o RESULTADO (em metros) do atleta 10: ");
            atletas[9].Distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Ordenação das posições:");
            Console.WriteLine("");
            Console.WriteLine("");

            var podium = atletas.OrderBy(atletas => atletas.Distancia);           
            foreach(var a in podium)
            {
            Console.WriteLine("{0} {1} {2}", a.Nome, a.Pais, a.Distancia);
            } 
        }   
    }
}

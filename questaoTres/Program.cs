using System;

namespace questaoTres
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, totalPagar;

            Console.WriteLine("Calculadora de impostos");
            Console.WriteLine("Informe o Valor: ");

            valor = Convert.ToDouble(Console.ReadLine());

            Icms impostoUm = new Icms(valor);
            Ipi impostoDois = new Ipi(valor);
            Cofins impostoTres = new Cofins(valor);

            Console.WriteLine("");
            Console.WriteLine("O valor a pagar de ICMS é : R$ {0}", impostoUm.calculaImposto(valor));
            Console.WriteLine("O valor a pagar de IPI é : R$ {0}", impostoDois.calculaImposto(valor));
            Console.WriteLine("O valor a pagar de COFINS é : R$ {0}", impostoTres.calculaImposto(valor));

            totalPagar = impostoUm.calculaImposto(valor) + impostoDois.calculaImposto(valor) + impostoTres.calculaImposto(valor);
            
            Console.WriteLine("");
            Console.WriteLine("O valor Total a pagar será de: R$ {0}", totalPagar);




        }
    }
}

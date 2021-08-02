namespace questaoTres
{
    public class Icms : IImposto
    {
        public double valor {get; set;}

        public Icms(double valor)
        {
            this.valor = valor;
        }

        public double calculaImposto(double valor)
        {
            double imposto = (valor) + (valor *  0.27);
            return imposto;
        }
    }
}
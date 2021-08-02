namespace questaoTres
{
    public class Cofins : IImposto
    {
        public double valor {get; set;}

        public Cofins(double valor)
        {
            this.valor = valor;
        }

        public double calculaImposto(double valor)
        {
            if(valor <= 13000)
            {
                return valor;
            }
            else
            {
            double imposto = (valor) + (valor *  0.04);
            return imposto;
            }
        }
    }
}

 
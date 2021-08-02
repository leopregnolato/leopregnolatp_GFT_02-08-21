namespace questaoTres
{
    public class Ipi : IImposto
    {
        public double valor {get; set;}

        public Ipi(double valor)
        {
            this.valor = valor;
        }

        public double calculaImposto(double valor)
        {
            if(valor < 25000)
            {
            double imposto = (valor) + (valor *  0.05);
            return imposto;
            }else{
            double imposto = (valor) + (valor *  0.11);
            return imposto;
            }
        }
    }
}

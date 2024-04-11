namespace Geometria
{
    internal class Cerchio : IFiguraChiusa
    {
        
        private readonly double raggio;

        public Cerchio(double raggio)
        {
            this.raggio = raggio;
        }

        public double Perimetro()
        {
            return raggio * 2 * Math.PI;
        }

        public double Area()
        {
            return Math.PI * raggio * raggio;
        }

        public string Descrizione()
        {
            return $"la circonferenza di raggio {raggio} è {Perimetro()} e l'area è {Area()}";
        }
    }
}

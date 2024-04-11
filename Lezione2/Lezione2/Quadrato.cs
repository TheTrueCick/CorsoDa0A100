


namespace Geometria
{
    internal class Quadrato : IFiguraChiusa
    {
        private readonly double lato;
        public Quadrato(double lato) {
            this.lato = lato;
        }
        public double Area()
        {
            return lato * lato;
        }

        public string Descrizione()
        {
            return $"Il perimetro del quadrato  di lato {lato} è {Perimetro()} e l'area è {Area()}";
        }

        public double Perimetro()
        {
            return 4*lato;
        }
    }
}

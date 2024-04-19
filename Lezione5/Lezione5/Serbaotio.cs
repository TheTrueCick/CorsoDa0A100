namespace Lezione5
{
    public class Serbaotio
    {
        private readonly double capacita;

        private  double quantita;

        public Serbaotio(double capacita)
        {
            this.capacita = capacita;
        }

        public double Quantita
        {
            //get { return quantita / capacita * 100; }
            get => quantita / capacita * 100;
            set => quantita += value;
        }

    }
}

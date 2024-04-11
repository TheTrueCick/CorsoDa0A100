using Geometria;

internal class Rettangolo:IFiguraChiusa
{
    private double @base;
    private double altezza;

    public Rettangolo(double @base, double altezza)
    {
        this.@base = @base;
        this.altezza = altezza;
    }

    public double Area()
    {
        return @base*altezza;
    }

    public string Descrizione()
    {
        return $"Il perimetro del rettangolo  di base {@base} ed altezza {altezza} è {Perimetro()} e l'area è {Area()}";
    }

    public double Perimetro()
    {
        return 2 * (@base + altezza);
    }
}
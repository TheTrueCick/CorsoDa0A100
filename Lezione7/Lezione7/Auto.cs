using Lezione7;

internal class Auto:IVeicolo
{
    public required Ruota[] Ruote { get; set; }
    public required Bagagliaio Contenitore { get; set; }
}

internal class Moto: IVeicolo
{
    public required Ruota[] Ruote { get; set; }
}
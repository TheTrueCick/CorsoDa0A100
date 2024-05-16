using Lezione7;

int numero = 2;
double dub = 4.8;

Console.WriteLine($"Esempio di cast esplicito {numero}");

IVeicolo fiat500 = new Auto() { 
    Contenitore =new Bagagliaio(), 
    Ruote = new Ruota[4] 
};
Moto  kawasaki = new Moto() { Ruote=new Ruota[2]};
Auto ferrari = new Auto()
{
    Contenitore = new Bagagliaio(),
    Ruote = new Ruota[4]
};

var successione=new Successione<IVeicolo>();
successione.Add(kawasaki);
successione.Add(fiat500);
successione.Add(ferrari);



var elemento=successione.First;
//Console.WriteLine($"ruote elemento: {elemento.Valore.Ruote.Length}");
//elemento=elemento.Next;
//Console.WriteLine($"ruote elemento: {elemento.Valore.Ruote.Length}");
//elemento = elemento.Next;
//Console.WriteLine($"ruote elemento: {elemento.Valore.Ruote.Length}");
//elemento = elemento.Next;
//Console.WriteLine($"ruote elemento: {elemento.Valore.Ruote.Length}");
while (elemento.Next != null)
{
    Console.WriteLine($"ruote elemento: {elemento.Valore.Ruote.Length}");
    elemento = elemento.Next;
}

var successioneInteri=new Successione<int>();
successioneInteri.Add(numero);
successioneInteri.Add((int)dub);
var elementoInt=successioneInteri.First;
while (elementoInt.Next != null)
{
    Console.WriteLine($"Valore: {elementoInt.Valore}");
    elementoInt = elementoInt.Next;
}
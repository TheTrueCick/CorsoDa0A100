using System.Xml.Linq;

int[] matrice = new int[10];

matrice[0] = 23;
matrice[5] = 12;

foreach (var elemento in matrice)
{
    Console.WriteLine(elemento);
}
Console.WriteLine("__--__--");
for (var indice = 0; indice < matrice.Length; indice++)
{
    Console.WriteLine($"alla posizione {indice+1} il valore è {matrice[indice]}");
}
Console.WriteLine("__--__--");
var indice2 = 110;
while(indice2 < matrice.Length)
{
    Console.WriteLine($"alla posizione {indice2 + 1} il valore è {matrice[indice2]}");
    indice2++;
}
Console.WriteLine(indice2);
Console.WriteLine("__--__--");
indice2 = 0;
do
{
    Console.WriteLine($"alla posizione {indice2 + 1} il valore è {matrice[indice2]}");
    indice2++;

} while (indice2 < matrice.Length);

string[,] scacchiera = new string[8,8];
for (int x =0;x<8;x++)
{
    for(int  y = 0; y < 8; y++)
    {
        scacchiera[x, y] =$"{x}{y+1}";
    }
}

for (int x = 0; x < 8; x++)
{
    for (int y = 0; y < 8; y++)
    {
        Console.Write(scacchiera[x, y]+" " );
    }
    Console.WriteLine();
}




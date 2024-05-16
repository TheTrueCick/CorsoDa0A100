
using Lezione7;

internal class Successione<T>
{

    public Nodo<T> First { get; private set; }

    private Nodo<T> last;

    public Successione()
    {
        First = new Nodo<T>();
        last = First;
    }

    internal void Add(T veicolo)
    {
        var actual = last;
        actual.Valore = veicolo;
        last = new Nodo<T>();
        actual.Next = last;
    }


}
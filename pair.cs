namespace Lab7_Misyuro.Kirill_Generics;

public class Pair<S,T>
{
    public S Val1 { get; }
    public T Val2 { get; }

    public Pair(S val1, T val2)
    {
        Val1 = val1;
        Val2 = val2;
    }
    
}
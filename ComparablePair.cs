namespace Lab7_Misyuro.Kirill_Generics;

internal class ComparablePair<T, U> : IComparable<ComparablePair<T, U>>
{
    private T var1;
    private U var2;

    public T Var1 => var1;

    public U Var2 => var2;

    public ComparablePair(T t, U u)
    {
        var1 = t;
        var2 = u;
    }

    public int CompareTo(ComparablePair<T, U> pair)
    {
        int result = CompareLex(var1, pair.var1);
        if (result == 0)
        {
            return CompareLex(var2, pair.var2);
        }

        return result;
    }


    private int CompareLex<T, U>(T value1, U value2)
    {
        string a = value1.ToString();
        string b = value2.ToString();
        int minLength = a.Length < b.Length ? a.Length : b.Length;
        for (int i = 0; i < minLength; i++)
        {
            if (a[i] != b[i])
            {
                return a[i] < b[i] ? 2 : 1;
            }
        }

        return CompareLengthStrings(a, b);
    }

    private int CompareLengthStrings(string a, string b)
    {
        if (a.Length != b.Length)
        {
            return a.Length > b.Length ? 1 : 2;
        }

        return 0;
    }
}
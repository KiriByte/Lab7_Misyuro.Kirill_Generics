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
        switch (CompareLex(var1, pair.var1))
        {
            case 0:
                switch (CompareLex(var2, pair.var2))
                {
                    case 0: return 0;
                    case 1: return 1;
                    case 2: return 2;
                }

                break;
            case 1: return 1;
            case 2: return 2;
        }

        return 0;
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
                if (a[i] < b[i])
                {
                    return 2;
                }

                if (a[i] > b[i])
                {
                    return 1;
                }
            }
        }

        if (CompareLengthStrings(a, b) != 0)
        {
            return CompareLengthStrings(a, b) == 1 ? 1 : 2;
        }

        return 0;
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
using System.Diagnostics.CodeAnalysis;

namespace Cover;

public class SumCode
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Sum2(int a, int b)
    {
        return a + b;
    }

    [ExcludeFromCodeCoverage]
    public static int Sum3(int a, int b)
    {
        return a + b;
    }
}

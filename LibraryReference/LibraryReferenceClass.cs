namespace LibraryReference;

public static class LibraryReferenceClass
{
    public static int Add(int x, int y) //this is a method within the public library class
    {
        return x + y;
    }
    public static int Sub(int x, int y)
    {
        return x - y;
    }
    public static int Div(int x, int y)
    {
        return x / y;
    }
    
    public static int Mult(int x, int y)
    {
        return x * y;
    }
    public static int Mod(int x, int y)
    {
        return x - (x / y * y);
    }

    public static int Squ(int x)
    {
        return x * x;
    }

    public static int Fact(int x)
    {
        var sum = 1;
        for(int i = x; i > 1; i--)
        {
            sum *= i;
        }
        return sum;
    }
}

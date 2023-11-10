public static class Program
{
    internal delegate short Action();

    private static Action Bar()
    {
        short foo = 0;

        Action code = delegate
        {
            foo++;
            return foo;
        };

        return code;
    }

    public static void Main()
    {
        Action zig = Bar();
        Action zag = Bar();

        short foo = zag(); 
        foo = zag();
        foo = zig();

        System.Console.Write(foo);
    }
}
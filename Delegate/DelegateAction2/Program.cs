public static class Program
{
    delegate void Action();
    delegate void Action2();

    public static void Main()
    {
        short foo = 0;

        Action2 code2 = delegate
        {
            foo = 5;
        };

        Action code = delegate
        {
            foo++;
        };


        code2();
        foo++;
        code();

        System.Console.Write(foo);
    }
}
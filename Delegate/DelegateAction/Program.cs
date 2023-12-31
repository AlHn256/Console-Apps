﻿public static class Program
{
    delegate void Action();
    delegate void Mutator(int value);

    public static void Main()
    {
        short foo = 0;

        Action code = delegate
        {
            foo++;
            Mutator zag = delegate (int value)
            {
                value++;
            };
            zag(foo);
        };

        foo++;
        code();

        System.Console.Write(foo);
    }
}
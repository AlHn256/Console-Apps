using System;
using System.Collections.Generic;

public static class Program
{
    static IEnumerable<int> GetInfinite()
    {
        while (true)
        {
            yield return 2;
        }
    }

    static IEnumerable<int> Get()
    {
        yield return 1;
        yield return 2;
        yield return 3;
    }

    public static void Main()
    {
        var dfj = Get();
        foreach (int el in dfj)
        {
            Console.WriteLine(el + "\n");
        }

        foreach (int el in GetInfinite())
        {
            Console.WriteLine(el);
        }
    }
}
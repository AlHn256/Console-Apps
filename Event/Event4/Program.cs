﻿sealed class Button
{
    internal delegate void Action();

    internal event Action OnClick;
    internal void FireClick()
    {
        OnClick();
    }
}

public static class Program
{
    public static void Main()
    {
        Button ok = new Button();

        ok.OnClick += delegate
        {
            System.Console.Write("this is it!");
        };

        ok.OnClick -= delegate
        {
            System.Console.Write("this is it!");
        };

        ok.FireClick();
    }
}
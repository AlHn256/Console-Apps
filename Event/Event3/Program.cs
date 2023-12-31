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

        Button.Action action = delegate
        {
            System.Console.Write("this is it!");
        };

        ok.OnClick += action;
        ok.OnClick -= action;

        ok.FireClick();
    }
}
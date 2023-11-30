﻿// This example demonstrates the Console.SetWindowSize method,
//                           the Console.WindowWidth property,
//                       and the Console.WindowHeight property.
using System;
using System.Collections.Generic;
using ZadarmaAPI;

class Sample
{
    public static void Main()
    {


        Random rnd = new Random();

        //var  value = rnd.Next(1000, 9999);
        int value =9911;

        var zadarma = new ZadarmaApi("997029", "xuH2tc69Lm");

        var parameters = new SortedDictionary<string, string>()
         {
             {"caller_id", "74951234567"},
             {"to", "79207670502"},
             {"code", value.ToString()},
             {"lang", "ru"}
         };
        var response = zadarma.Call("/v1/request/checknumber/", parameters);
        var resp = response.Content.ReadAsStringAsync().Result;
        Console.WriteLine(resp);
    }
}
/*
This example produces the following results:

The current window width is 85, and the current window height is 43.
  (Press any key to continue...)
The new window width is 42, and the new window height is 21.
  (Press any key to continue...)
The current window width is 85, and the current window height is 43.

*/
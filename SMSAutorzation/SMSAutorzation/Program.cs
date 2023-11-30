using System;
using System.Collections.Generic;
using ZadarmaAPI;

class Sample
{
    public static void Main()
    {
        Random rnd = new Random();

        //var  value = rnd.Next(1000, 9999);
        int value = 9911;
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
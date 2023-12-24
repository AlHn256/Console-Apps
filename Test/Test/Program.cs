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

        foreach(var elem in Data())
        {
            Console.WriteLine(elem);
        }
    }


    public static IEnumerable<int> Data()
    {
        yield return 1;
        yield return 2;
        yield return 3;
        yield return 4;
        yield return 5;
    }
}
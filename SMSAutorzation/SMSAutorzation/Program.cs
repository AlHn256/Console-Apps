using System;
using System.Collections.Generic;
using ZadarmaAPI;

class Sample
{
    public static void Main()
    {
        int value = new Random().Next(1000, 9999);
        var zadarma = new ZadarmaApi("509289a01f9aa4e0a1e4", "99def24c62f06517cfa6");
        var parameters = new SortedDictionary<string, string>()
         {
             {"caller_id", "79207670502"},
             {"to", "444455"},
             {"code", value.ToString()},
             {"lang", "ru"}
         };
        var response = zadarma.Call("/v1/request/checknumber/", parameters);
        var resp = response.Content.ReadAsStringAsync().Result;
        Console.WriteLine(resp);
    }
}
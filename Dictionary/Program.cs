using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            //DICTIONARY come hashtable ma bisogna definire chiave (non possono essere generiche)
            Dictionary<string, string> prova = new Dictionary<string, string>()
            {
                {"Lombardia", "milano" },
                {"Liguria", "genova" },
                {"Piemonte", "torino" }
            };
            prova.Add("Veneto", "venezia");
            prova["Veneto"] = "palermo";
            prova.Remove("Veneto");

            foreach(KeyValuePair<string, string> item in prova)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            prova.Clear();
        }
    }
}

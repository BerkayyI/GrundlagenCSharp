using System.Text.Json;

class NameValuePair
{
    public string Name { get; set; }
    public int Value { get; set; }
}

public class Array1
{

    public static void Main()
    {
        Array_Auf3();
    }


    public static void Array_Auf1()
    {
        NameValuePair[] pairs = new NameValuePair[4];

        // Initialize array elements with instances of NameValuePair
        pairs[0] = new NameValuePair { Name = "Alice", Value = 25 };
        pairs[1] = new NameValuePair { Name = "Bob", Value = 30 };
        pairs[2] = new NameValuePair { Name = "Charlie", Value = 22 };
        pairs[3] = new NameValuePair { Name = "David", Value = 28 };


        foreach (var pair in pairs)
        {
            Console.WriteLine($"{pair.Name}, {pair.Value}");
        }
    }

    public static void Array_Auf2()
    {
        //Der Pfad beim Debuggen
        string jsonString = File.ReadAllText(@"..\..\..\Namelist.json");

        //Der Pfad beim Ausführen
        //jsonString = File.ReadAllText(@"Namelist.json");

        //Daten werden in ein String gespeichert
        var jsonArray = JsonSerializer.Deserialize<string[]>(jsonString);

        //Ausgabe aller Namen 
        for (int i = 0; i < jsonArray.Length; i++)
        {
            Console.WriteLine(jsonArray[i]);
        }


    }

    public static void Array_Auf3()
    {

        // 3,1
        string[] gehaltliste = new string[] { "3445", "2986", "4563" , "2309" };
       
        gehaltliste[2] = "5481";

        for(int i = 0; i < gehaltliste.Length; i++)
        {
            Console.WriteLine(gehaltliste[i]);
        }
        Console.WriteLine();

        // 3,2

        gehaltliste[3] = "6989";

        for (int i = 0; i < gehaltliste.Length; i++)
        {
            Console.WriteLine(gehaltliste[i]);
        }

        Console.WriteLine();

        // 3.3

        Console.WriteLine(gehaltliste[2]);


    }
}

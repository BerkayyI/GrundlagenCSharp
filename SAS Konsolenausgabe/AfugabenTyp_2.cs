using System.Text.Json;


public class Schleifen
{

    public static void Main()
    {
        Array_auf10();
    }


    public static void Array_Auf1()
    {
        int count = 50;

        while (count >= 0)  
        {
            Console.WriteLine(count);  
            count--;  
        }

    }
    public static void Array_Auf2()
    {
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine("Ich muss immer meine Hausaufgaben machen");
        }

    }
    public static void Array_Auf3()
    {
        for (int i = 1; i <= 10; i++)
        {
            int square = i * i;
            Console.WriteLine($"Das Quadrat von {i} ist {square}");
        }
    }

    public static void Array_auf4()
    {
        for (int i = 100; i >= 10; i -= 10)
        {
            Console.Write($"{i} ");
        }
    }
    public static void Array_auf5()
    {
        Console.Write("Geben Sie eine Zahl x ein: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = -x; i <= x; i += 2)
        {
            Console.Write($"{i} ");
        }
    }
    public static void Array_auf6()
    {

    }
    public static void Array_auf7()
    {
        Console.Write("Geben Sie eine Zahl n ein: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Die Summe der Zahlen von 0 bis {n} ist {sum}");
    }
    public static void Array_auf8()
    {
        int pin = 1234;
        int attempts = 0;
        int enteredPin;

        do
        {
            Console.Write("Geben Sie die PIN ein: ");
            enteredPin = int.Parse(Console.ReadLine());
            attempts++;

            if (enteredPin != pin)
            {
                Console.WriteLine("Falsche PIN.");
            }

        } while (enteredPin != pin);

        Console.WriteLine($"Korrekte PIN eingegeben nach {attempts - 1} falschen Versuchen.");
    }
    public static void Array_auf9()
    {
        Console.Write("Geben Sie das Kapital K ein: ");
        double K = double.Parse(Console.ReadLine());

        Console.Write("Geben Sie den Zinssatz p in Prozent ein: ");
        double p = double.Parse(Console.ReadLine()) / 100;  // Convert percentage to decimal

        int years = CalculateYearsToDouble(K, p);

        Console.WriteLine($"Das Kapital wird sich in {years} Jahren verdoppeln.");
    }

    static int CalculateYearsToDouble(double K, double p)
    {
        int years = 0;

        while (K < K * 2)
        {
            K += K * p;
            years++;
        }

        return years;
    }


    public static void Array_auf10()
    {
        Console.Write("Geben Sie die Höhe des Weihnachtsbaums ein: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            Console.Write(new string(' ', height - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }



}

class MyClass
{
    public static void Main()
    {
        Body_Mass_Index();
        BabdjiMobile();
        Fortinite();
    }
    static void Body_Mass_Index() // M ist Gewicht in kg | I Eingabe in cm, Umrechnung in m
    {
        double I;
        double M;
        double BMI;
        
        Console.WriteLine("Geben sie ihre Körpergröße ein (cm): ");

        string I_s = Console.ReadLine();
        I = Convert.ToDouble(I_s);
        I = I / 100;
 

        Console.WriteLine("Geben sie ihr Gewicht ein (kg): ");

        string M_s = Console.ReadLine();
        M = Convert.ToDouble(M_s);
        

        BMI = M / (I * I);

        Console.WriteLine($"Ihr Body-Mass-Index ist {BMI:F1}");

        if (BMI >= 25)
        {
            Console.WriteLine("Sie sind Überewichtig XD");
        }
        else if (BMI <= 18.5)
        {
            Console.WriteLine("Sie sind Untergewichtig");
        }
        else
        {
            Console.WriteLine("Sie haben ein normales gewicht");
        }
       
    }
    
    static void BabdjiMobile()
    {
        Console.WriteLine("Wie viele Jahre Arbeiten sie hier schon ?");
        string Year = Console.ReadLine();
        int Y = Convert.ToInt32(Year);

        if (Y <= 3)
        {
            Console.WriteLine("Sie kriegen noch keine Treueprämie.");
        }
        if (Y >= 4 && Y <= 10)
        {
            Console.WriteLine("Sie kriegen 150 EURO Treueprämie pro Jahr.");
        }
        if (Y >= 10)
        {
            Console.WriteLine("Sie kriegen auf die 150 EURO noch 10 EURO drauf pro Jahr.");

        }
    }

    static void Fortinite()
    {
        Console.WriteLine("Bitte wählen sie eine Winkelfunktion aus.\n");
        Console.WriteLine("1. Cosinus\n2. Sinus\n3. Tangens");
        string auswahl = Console.ReadLine();
        int A = Convert.ToInt32(auswahl);

        Console.WriteLine("Geben Sie einen Winkelgrad ein. ");
        string auswahl2 = Console.ReadLine();
        double B = Convert.ToDouble(auswahl2);

        double ehehe;
        
        switch (A)
        {
            case 1:
                ehehe = Math.Cos(B);
                Console.WriteLine(ehehe);
                break;
            case 2:
                ehehe = Math.Sin(B);
                Console.WriteLine(ehehe);
                break;
            case 3:
                ehehe = Math.Tan(B);
                Console.WriteLine(ehehe);
                break;
            default:
                break;
        }

    }

}

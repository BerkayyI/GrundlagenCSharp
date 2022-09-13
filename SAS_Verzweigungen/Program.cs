using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Threading.Tasks.Dataflow;

class Aufgaben_SAS_Verzweigungen
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Welche Aufgabe wollen sie sehen ?\nOptions [1],[2],[3],[4]");
            string Answer = Console.ReadLine();
            if (Answer == "1")
            {
                Console.Clear();
                Aufgabe1();
                Console.Clear();
                continue;
            }

            if (Answer == "2")
            {
                Console.Clear();
                Aufgabe2();
                Console.Clear();
                continue;
            }

            if (Answer == "3")
            {
                Console.Clear();
                Aufgabe3();
                Console.Clear();
                continue;
            }

            if (Answer == "4")
            {
                Console.Clear();
                Aufgabe4();
                Console.Clear();
                continue;

            }

            else
            {
                return;
            }

        }
    }

    static void Aufgabe1()
    {
        Random r = new Random();
        int LowNum = r.Next(1, 5);
        int HighNum = r.Next(5, 10);
        Console.WriteLine("Welche Nummer ist die kleinste {0} oder {1}", LowNum, HighNum);
        string answer = Console.ReadLine();
        int ConvertAnswerToInt = Convert.ToInt32(answer);
        if (ConvertAnswerToInt == LowNum)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Falsch glück beim nächsten Mal es war {0}", LowNum);
        }
        Thread.Sleep(2500);

    }

    static void Aufgabe2()
    {
        Random r = new Random();
        int SpecialNum = r.Next(0, 1000);
        Console.WriteLine("Rate die Zahl zwischen 0-1000");

        while (true)
        {
            string Answer = Console.ReadLine();
            int ConvertAnswerToInt = Convert.ToInt32(Answer);

            if (ConvertAnswerToInt == SpecialNum)
            {
                Console.WriteLine("Du hast gewonnen!");
                break;

            }
            if (ConvertAnswerToInt > SpecialNum)
            {

                Console.WriteLine("die Zahl ist niedriger als {0}", ConvertAnswerToInt);

            }
            if (ConvertAnswerToInt < SpecialNum)
            {

                Console.WriteLine("die Zahl ist höher als {0}", ConvertAnswerToInt);

            }
        }
        Thread.Sleep(3500);

    }

    static void Aufgabe3()
    {
        Console.WriteLine("Unser spezieller Herzinfarkt-Risikotest!");
        Console.WriteLine("Sind Sie übergewichtig?");
        string OverWeight = Console.ReadLine();
        Console.WriteLine("Haben sie stress?");
        string HasStress = Console.ReadLine();
        if (OverWeight.ToLower() == "ja" && HasStress.ToLower() == "ja")
        {
            Console.WriteLine("Sie haben eine Wahrscheinlichkeit von 62 %, einen Herzinfarkt zu erleiden.");
        }
        if (OverWeight.ToLower() == "ja" && HasStress.ToLower() == "nein")
        {
            Console.WriteLine("Sie haben eine Wahrscheinlichkeit von 18 %, einen Herzinfarkt zu erleiden.");
        }
        if (OverWeight.ToLower() == "nein" && HasStress.ToLower() == "ja")
        {
            Console.WriteLine("Sie haben eine Wahrscheinlichkeit von 15 %, einen Herzinfarkt zu erleiden.");
        }
        if (OverWeight.ToLower() == "nein" && HasStress.ToLower() == "nein")
        {
            Console.WriteLine("Sie haben eine Wahrscheinlichkeit von 5 %, einen Herzinfarkt zu erleiden.");
        }

        Thread.Sleep(3500);
    }



    static void Aufgabe4()
    {
        Console.WriteLine("Geben Sie Ihre erste Zahl ein");
        string N1 = Console.ReadLine();
        Console.WriteLine("Geben Sie Ihre zweite Zahl ein");
        string N2 = Console.ReadLine();
        double ConvertN1 = Convert.ToDouble(N1);
        double ConvertN2 = Convert.ToDouble(N2);
        Console.WriteLine("Was möchten sie machen?\n1 Addition\n2 Subtraktion\n3 Multiplikation\n4 Division\n5 Potenz\n ");
        string Answer = Console.ReadLine();
        Console.WriteLine("Ihre Auswahl: {0}", Answer);
        double ConvertAnswer = Convert.ToDouble(Answer);

        switch (ConvertAnswer)
        {

            case 1:
                double CalcAddition = (double)ConvertN1 + ConvertN2;
                Console.WriteLine("Ihr Ergebnis ist: {0}", CalcAddition);
                break;

            case 2:
                double CalcSubtraktion = (double)ConvertN1 - ConvertN2;
                Console.WriteLine("Ihr Ergebnis ist: {0}", CalcSubtraktion);
                break;

            case 3:
                double CalcMultiplikation = (double)ConvertN1 * ConvertN2;
                Console.WriteLine("Ihr Ergebnis ist: {0}", CalcMultiplikation);
                break;

            case 4:
                double CalcDivision = (double)ConvertN1 / ConvertN2;
                Console.WriteLine("Ihr Ergebnis ist: {0}", CalcDivision);
                break;

            case 5:
                double CalcPotenz = Math.Pow(ConvertN1, ConvertN2);
                Console.WriteLine("Ihr Ergebnis ist: {0}", CalcPotenz);
                break;

            default:
                Console.WriteLine("Not valid option!");
                break;

        }


        Console.WriteLine("Wollen sie nochmal rechnen?\n");
        string Ans = Console.ReadLine();
        if (Ans.ToLower() == "ja")
        {
            Console.Clear();
            Aufgabe4();
        }
        else
        {
            return;
        }



    }
}
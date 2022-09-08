using System.Reflection.Metadata.Ecma335;

class Aufgaben_SAS_Verzweigungen
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Which Aufgabe you wanna see ?\nOptions [1],[2],[4]");
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
        Console.WriteLine("Which Number is the smallest {0} or {1}", LowNum, HighNum);
        string answer = Console.ReadLine();
        int ConvertAnswerToInt = Convert.ToInt32(answer);
        if (ConvertAnswerToInt == LowNum)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("False good luck next time it was {0}", LowNum);
        }

    }

    static void Aufgabe2()
    {
        Random r = new Random();
        int SpecialNum = r.Next(0, 1000);
        Console.WriteLine("Guess the number between 0-1000");

        while (true)
        {
            string Answer = Console.ReadLine();
            int ConvertAnswerToInt = Convert.ToInt32(Answer);

            if (ConvertAnswerToInt == SpecialNum)
            {
                Console.WriteLine("You won");
                break;

            }
            if (ConvertAnswerToInt > SpecialNum)
            {

                Console.WriteLine("the Number is lower");

            }
            if (ConvertAnswerToInt < SpecialNum)
            {

                Console.WriteLine("the Number is Higher");

            }
        }

    }

    static void Aufgabe4()
    {
        Console.WriteLine("Input your first number");
        string N1 = Console.ReadLine();
        Console.WriteLine("Input your second number");
        string N2 = Console.ReadLine();
        short ConvertN1 = Convert.ToInt16(N1);
        short ConvertN2 = Convert.ToInt16(N2);
        Console.WriteLine("What would you like to do?\n1 Addition\n2 Subtraktion\n3 Multiplikation\n4 Division\n5 Potenz\n ");
        string Answer = Console.ReadLine();
        Console.WriteLine("Ihre Auswahl: {0}", Answer);
        short ConvertAnswer = Convert.ToInt16(Answer);

        switch (ConvertAnswer)
        {

            case 1:
                var CalcAddition = ConvertN1 + ConvertN2;
                Console.WriteLine("Ihr Ergebnis ist: {0}", CalcAddition);
                break;

            case 2:
                var CalcSubtraktion = ConvertN1 - ConvertN2;
                Console.WriteLine("Ihr Ergebnis ist: {0}", CalcSubtraktion);
                break;

            case 3:
                var CalcMultiplikation = ConvertN1 * ConvertN2;
                Console.WriteLine("Ihr Ergebnis ist: {0}", CalcMultiplikation);
                break;

            case 4:
                var CalcDivision = ConvertN1 / ConvertN2;
                Console.WriteLine("Ihr Ergebnis ist: {0}", CalcDivision);
                break;

            case 5:
                var CalcPotenz = Math.Pow(ConvertN1, ConvertN2);
                Console.WriteLine("Ihr Ergebnis ist: {0}", CalcPotenz);
                break;

            default:
                Console.WriteLine("Not valid option!");
                break;

        }

        Console.WriteLine("Wanna calculate again?\n");
        string Ans = Console.ReadLine();
        if (Ans == "yes")
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
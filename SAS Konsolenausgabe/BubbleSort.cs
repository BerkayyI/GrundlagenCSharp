using System;
using static System.Net.Mime.MediaTypeNames;

public class BubbleSort_Solver
{
    
    public static void Main()
    {

        while (true)
        {
            int Min = 0;
            int Max = 100;

            Random randNum = new Random();

            int[] test2 = new int[15];


           for (int i = 0; i < test2.Length; i++)
           {
              test2[i] = randNum.Next(Min, Max);
              PrintBarLine(test2[i]);
           }

            Console.ReadKey();
            Console.Clear();

            BubbleSort(test2);



            foreach (int num in test2)
            {

                PrintBarLine(num);

            }



            Console.ReadKey();
            Console.Clear();
        }
    }



    public static void BubbleSort(int[] nArray)
    {
        int Number = nArray.Length;

        for (int outerPerform = 0; outerPerform < Number - 1; outerPerform++)
        {


            for (int innerPerform = 0; innerPerform < Number - outerPerform - 1; innerPerform++)
            {



                if (nArray[innerPerform] > nArray[innerPerform + 1])
                {

                    for (int i = 0; i < nArray.Length; i++)
                    {
                        
                        PrintBarLine(nArray[i]);
                    }

                    int temp = nArray[innerPerform];
                    nArray[innerPerform] = nArray[innerPerform + 1];
                    nArray[innerPerform + 1] = temp;
                    Thread.Sleep(200);
                    Console.Clear();
                    
                }
            }
            
        }
    }


    public static void PrintBarLine(int value)
    {
        for (int i = 0; i < value; i++)
        {
            Console.Write("█"); // Print a bar character for each iteration
        }

        Console.WriteLine($" {value} Characters\n");
    }

}



using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // PROGRAM 2
            
        string input = "";
        bool isEven;

        for (int i = 0; i < 2000; i++)
        {
            isEven = true;
            input = Console.ReadLine();

            if (input == "END")
                break;

            string inputTrimmed;
            if (input.Length > 2)
            {
                inputTrimmed = input.Substring(1, input.Length - 2);
            }
            else
            {
                inputTrimmed = input;
            }

            var blackPixelsArray = input.Split(".", StringSplitOptions.RemoveEmptyEntries);
            var whitePixelsArray = inputTrimmed.Split("*");

            int whitePixelsCheck;
            whitePixelsCheck = whitePixelsArray[0].Length;

            for (int j = 0; j < whitePixelsArray.Length; j++)
            {
                if (whitePixelsArray[j].Length != whitePixelsCheck)
                {
                    isEven = false;
                    break;
                }
            }

            int blackPixelsCheck;
            blackPixelsCheck = blackPixelsArray[0].Length;

            for(int j = 0; j < blackPixelsArray.Length; j++)
            {
                if (blackPixelsArray[j].Length != blackPixelsCheck)
                {
                    isEven = false;
                    break;
                }
            }

            if (isEven)
            {
                Console.WriteLine("{0} EVEN", i + 1);
            }
            else
            {
                Console.WriteLine("{0} NOT EVEN", i + 1);
            }
        }
    }
}
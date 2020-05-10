using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string line;
        int caseCount = 1;

        while ((line = Console.ReadLine()) != null)
        {
            List<string> exp = line.Split(' ').ToList();
            int i = exp.Count - 1;

            while (i >= 2)
            {
                int a, b;
                if (Int32.TryParse(exp[i - 1], out a) && Int32.TryParse(exp[i], out b))
                {
                    if (exp[i - 2] == "+" || exp[i - 2] == "-" || exp[i - 2] == "*")
                    {
                        int num;
                        if (exp[i - 2] == "+")
                        {
                            num = a + b;
                        }
                        else if (exp[i - 2] == "-")
                        {
                            num = a - b;
                        }
                        else
                        {
                            num = a * b;
                        }
                        exp[i - 2] = num.ToString();
                        exp.RemoveRange(i - 1, 2);

                        i = exp.Count - 1;
                    }
                    else
                    {
                        i -= 1;
                    }
                }
                else
                {
                    i -= 1;
                }
            }

            Console.WriteLine("Case {0}: {1}", caseCount, string.Join(" ", exp));

            caseCount += 1;
        }
    }
}
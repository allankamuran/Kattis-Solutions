using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // PROGRAM 1
        
        float Gunnardice1Average;
        float Gunnardice2Average;

        string inputGunnar = "";

        inputGunnar = Console.ReadLine();

        var numberarrayGunnar = inputGunnar.Split(" ");

        Gunnardice1Average = (Int32.Parse(numberarrayGunnar[0]) + Int32.Parse(numberarrayGunnar[1]));
        Gunnardice2Average = (Int32.Parse(numberarrayGunnar[2]) + Int32.Parse(numberarrayGunnar[3]));

        float GunnarTotalAverage = Gunnardice1Average + Gunnardice2Average;

        float Emmadice1Average;
        float Emmadice2Average;

        string inputEmma = "";

        inputEmma = Console.ReadLine();

        var numberarrayEmma = inputEmma.Split(" ");

        Emmadice1Average = (Int32.Parse(numberarrayEmma[0]) + Int32.Parse(numberarrayEmma[1]));
        Emmadice2Average = (Int32.Parse(numberarrayEmma[2]) + Int32.Parse(numberarrayEmma[3]));

        float emmaTotalAverage = Emmadice1Average + Emmadice2Average;

        if (GunnarTotalAverage > emmaTotalAverage){
            Console.WriteLine("Gunnar");
        }
        else if (GunnarTotalAverage < emmaTotalAverage){
            Console.WriteLine("Emma");
        }
        else{
            Console.WriteLine("Tie");
        }
    }
}
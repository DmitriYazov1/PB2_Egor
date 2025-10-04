/*using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Arithmetic_Mean
    {
    }
}*/

class Task2
{    
    public static void Run()
    {
        double b = 0;


        Console.WriteLine("Введите 3 числа: ");
        
        for (int i = 0; i < 3; i++)
        {
            double a = Convert.ToDouble(Console.ReadLine());

            b +=  a;
        }

        b = b / 3;

        Console.WriteLine($"Среднее арифметическое чисел: {b}");
    }
 
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        if (num1 == num2)
        {
            Console.WriteLine("Два числа равны");
        }
        else if (num1 > num2)
        {
            Console.WriteLine("Первое число больше второго");
        }
        else
        {
            Console.WriteLine("Первое число меньше второго");
        }
    }
}
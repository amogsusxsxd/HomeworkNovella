using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        double deposit = Convert.ToDouble(Console.ReadLine());
        double interestRate = 0;
        
        if (deposit < 100)
        {
            interestRate = 0.05; // 5%
        }
        else if (deposit >= 100 && deposit <= 200)
        {
            interestRate = 0.07; // 7%
        }
        else if (deposit > 200)
        {
            interestRate = 0.10; // 10%
        }
        
        double totalAmount = deposit + (deposit * interestRate);
        Console.WriteLine($"Сумма вклада с начисленными процентами: {totalAmount:F2}");
    }
}
using System;

class Novella
{
    static int karma = 0;
    
    static void Main()
    {
        Console.WriteLine("=== ВЫБОР СУДЬБЫ ===");
        Console.WriteLine("Нажмите Enter чтобы начать...");
        Console.ReadLine();
        
        Step1();
    }
    
    static void Step1()
    {
        Console.Clear();
        Console.WriteLine("ШАГ 1: ПРОБУЖДЕНИЕ");
        Console.WriteLine("Вы просыпаетесь в незнакомом лесу. Рядом слышен шум реки.");
        Console.WriteLine("1. Пойти на шум реки");
        Console.WriteLine("2. Остаться на месте и осмотреться");
        
        int choice = GetChoice(2);
        
        if (choice == 1)
        {
            karma++;
            Step2_River();
        }
        else
        {
            Step2_Forest();
        }
    }
    
    static void Step2_River()
    {
        Console.Clear();
        Console.WriteLine("ШАГ 2: У РЕКИ");
        Console.WriteLine("Вы находите быструю реку. На противоположном берегу виден дым костра.");
        Console.WriteLine("1. Попытаться переплыть реку");
        Console.WriteLine("2. Идти вдоль берега");
        
        int choice = GetChoice(2);
        
        if (choice == 1)
            Step3_Swim();
        else
            Step3_Walk();
    }
    
    static void Step2_Forest()
    {
        Console.Clear();
        Console.WriteLine("ШАГ 2: В ЛЕСУ");
        Console.WriteLine("Вы замечаете старую заброшенную хижину и странные следы.");
        Console.WriteLine("1. Исследовать хижину");
        Console.WriteLine("2. Проследовать за следами");
        
        int choice = GetChoice(2);
        
        if (choice == 1)
            Step3_House();
        else
            Step3_Tracks();
    }
    
    static void Step3_Swim()
    {
        Console.Clear();
        Console.WriteLine("ШАГ 3: ПЕРЕПРАВА");
        Console.WriteLine("Течение слишком сильное! Вас сносит вниз по реке.");
        karma--;
        Step4_Rescue();
    }
    
    static void Step3_Walk()
    {
        Console.Clear();
        Console.WriteLine("ШАГ 3: ВДОЛЬ РЕКИ");
        Console.WriteLine("Вы находите брод и безопасно переходите на другой берег.");
        karma++;
        Step4_Campfire();
    }
    
    static void Step3_House()
    {
        Console.Clear();
        Console.WriteLine("ШАГ 3: ЗАБРОШЕННАЯ ХИЖИНА");
        Console.WriteLine("В хижине вы находите старую карту и меч.");
        karma += 2;
        Step4_Map();
    }
    
    static void Step3_Tracks()
    {
        Console.Clear();
        Console.WriteLine("ШАГ 3: СЛЕДЫ");
        Console.WriteLine("Следы приводят вас к логову волков! Придется сражаться.");
        Step4_Fight();
    }
    
    
    static void ShowEnding()
    {
        Console.Clear();
        Console.WriteLine("=== КОНЕЦ ИГРЫ ===");
        
        if (karma >= 5)
            Console.WriteLine("КОНЦОВКА: ГЕРОЙ СВЕТА\nВы спасли королевство и стали легендой!");
        else if (karma >= 2)
            Console.WriteLine("КОНЦОВКА: БЛАГОРОДНЫЙ ПУТЕШЕСТВЕННИК\nВы нашли свой путь домой.");
        else if (karma >= -2)
            Console.WriteLine("КОНЦОВКА: НЕЙТРАЛЬНЫЙ ИСХОД\nВы выжили, но ваши действия остались незамеченными.");
        else if (karma >= -4)
            Console.WriteLine("КОНЦОВКА: ТЕМНЫЙ СТРАННИК\nВы выбрали путь тьмы...");
        else
            Console.WriteLine("КОНЦОВКА: ПРЕДАТЕЛЬ\nВы погубили королевство ради собственной выгоды.");
            
        Console.WriteLine($"Ваша карма: {karma}");
    }
    
    static int GetChoice(int maxChoice)
    {
        int choice;
        while (true)
        {
            Console.Write($"Введите выбор (1-{maxChoice}): ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= maxChoice)
                return choice;
            Console.WriteLine("Неверный ввод!");
        }
    }
}
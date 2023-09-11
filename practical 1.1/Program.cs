using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        Console.WriteLine("Генерація псевдовипадкової послідовності чисел:");
        for (int i = 0; i < 10; i++)
        {
            int randomNumber = random.Next(1, 101); 
            Console.WriteLine(randomNumber);
        }

        int firstRandomNumber = random.Next(1, 101);
        int secondRandomNumber = random.Next(1, 101);

        Console.WriteLine($"Перше випадкове число: {firstRandomNumber}");
        Console.WriteLine($"Друге випадкове число: {secondRandomNumber}");

        if (firstRandomNumber == secondRandomNumber)
        {
            Console.WriteLine("Обидва числа однакові.");
        }
        else
        {
            Console.WriteLine("Числа різні.");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть ваше ім'я: ");
        var userName = Console.ReadLine();

        Console.Write("Введіть ваш вік: ");
        var ageInput = Console.ReadLine();

        if (!int.TryParse(ageInput, out var age))
        {
            Console.WriteLine("Помилка: вік має бути числом.");
            return;
        }

        Console.WriteLine($"Користувач: {userName}, вік: {age}");
    }
}

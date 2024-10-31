using System;

class Program
{
    // Метод для получения второй справа цифры числа
    static int f(int x)
    {
        // Убедимся, что x - натуральное число
        if (x < 10)
        {
            return 0; // Если число меньше 10, второй цифры нет
        }

        // Находим вторую справа цифру
        return (x / 10) % 10;
    }

    static void Main(string[] args)
    {
        // Запрашиваем у пользователя ввод значений a, b и c
        Console.Write("Введите значение a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите значение b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите значение c: ");
        int c = int.Parse(Console.ReadLine());

        // Вычисляем z
        int z = f(a) + f(b) - f(c);

        // Выводим результат
        Console.WriteLine($"z = f(a) + f(b) - f(c) = {z}");
    }
}
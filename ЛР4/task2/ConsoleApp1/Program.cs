using System;

class Program
{
    // Метод для нахождения наибольшей четной цифры в числе
    static int FindMaxEvenDigit(int number)
    {
        int maxEvenDigit = -1; // Инициализируем переменную для хранения максимальной четной цифры

        while (number > 0)
        {
            int digit = number % 10; // Получаем последнюю цифру числа
            if (digit % 2 == 0) // Проверяем, является ли цифра четной
            {
                if (digit > maxEvenDigit) // Если цифра больше текущей максимальной четной цифры
                {
                    maxEvenDigit = digit; // Обновляем максимальную четную цифру
                }
            }
            number /= 10; // Убираем последнюю цифру из числа
        }

        return maxEvenDigit; // Возвращаем наибольшую четную цифру или -1, если четных нет
    }

    static void Main(string[] args)
    {
        Console.Write("Введите количество чисел (N): ");
        int N = int.Parse(Console.ReadLine()); // Читаем количество чисел

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            int number = int.Parse(Console.ReadLine()); // Читаем число

            int maxEvenDigit = FindMaxEvenDigit(number); // Находим максимальную четную цифру

            if (maxEvenDigit == -1)
            {
                Console.WriteLine("В числе нет четных цифр.");
            }
            else
            {
                Console.WriteLine($"Наибольшая четная цифра в числе {number}: {maxEvenDigit}");
            }
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрос у пользователя ввода размера массива
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine());

        // Создание массива заданного размера
        int[] array = new int[n];

        // Ввод элементов массива
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // Вызов функции для подсчета пар
        int count = CountOddSumPairs(array);

        // Вывод результата
        Console.WriteLine($"Количество пар соседних элементов с нечетной суммой: {count}");
    }

    static int CountOddSumPairs(int[] array)
    {
        int count = 0;

        // Проход по массиву и проверка соседних элементов
        for (int i = 0; i < array.Length - 1; i++)
        {
            // Проверка, является ли сумма соседних элементов нечетной
            if ((array[i] + array[i + 1]) % 2 != 0)
            {
                count++;
            }
        }

        return count;
    }
}
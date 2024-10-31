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

        // Определяем максимальный простой элемент и среднее арифметическое простых чисел до вставки
        int maxPrime = FindMaxPrime(array);
        double averageBefore = CalculateAverageOfPrimes(array);

        Console.WriteLine($"Максимальный простой элемент: {maxPrime}");
        Console.WriteLine($"Среднее арифметическое простых элементов до вставки: {averageBefore}");

        // Модифицируем массив, вставляя максимальный простой элемент после каждого нечетного элемента
        ModifyArray(ref array, maxPrime);

        // Вычисляем среднее арифметическое простых элементов после вставки
        double averageAfter = CalculateAverageOfPrimes(array);

        // Вывод модифицированного массива
        Console.WriteLine("Модифицированный массив:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine($"nСреднее арифметическое простых элементов после вставки: {averageAfter}");
    }

    static int FindMaxPrime(int[] array)
    {
        int maxPrime = int.MinValue;

        foreach (var number in array)
        {
            if (IsPrime(number) && number > maxPrime)
            {
                maxPrime = number;
            }
        }

        return maxPrime == int.MinValue ? 0 : maxPrime; // Возвращаем 0, если простых чисел нет
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static double CalculateAverageOfPrimes(int[] array)
    {
        int sum = 0;
        int count = 0;

        foreach (var number in array)
        {
            if (IsPrime(number))
            {
                sum += number;
                count++;
            }
        }

        return count > 0 ? (double)sum / count : 0; // Если простых чисел нет, возвращаем 0
    }

    static void ModifyArray(ref int[] array, int maxPrime)
    {
        int n = array.Length;

        // Проходим по массиву и вставляем максимальный простой элемент после каждого нечетного числа
        for (int i = 0; i < n; i++)
        {
            if (array[i] % 2 != 0) // Если число нечетное
            {
                // Увеличиваем размер массива
                Array.Resize(ref array, array.Length + 1);

                // Сдвигаем элементы вправо для освобождения места
                for (int j = array.Length - 1; j > i + 1; j--)
                {
                    array[j] = array[j - 1];
                }

                // Вставляем максимальный простой элемент
                array[i + 1] = maxPrime;

                // Увеличиваем индекс, чтобы пропустить вставленный элемент
                i++;
            }
        }
    }
}
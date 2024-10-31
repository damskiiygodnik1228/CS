using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        // Получаем уникальные символы
        string uniqueChars = GetUniqueCharacters(input);
        int maxCount = 0;
        string mostFrequentChars = "";

        // Подсчет вхождений каждого уникального символа
        foreach (char c in uniqueChars)
        {
            int count = CountOccurrences(input, c);
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequentChars = c.ToString(); // Обновляем наиболее частый символ
            }
            else if (count == maxCount)
            {
                mostFrequentChars += c; // Добавляем символ, если он встречается так же часто
            }
        }

        // Выводим результат
        Console.WriteLine("Наиболее часто встречающиеся символы:");
        Console.WriteLine(mostFrequentChars);
    }

    static string GetUniqueCharacters(string str)
    {
        string unique = "";
        foreach (char c in str)
        {
            if (!unique.Contains(c)) // Проверяем, есть ли уже этот символ
            {
                unique += c; // Добавляем уникальный символ
            }
        }
        return unique;
    }

    static int CountOccurrences(string str, char c)
    {
        int count = 0;
        foreach (char ch in str)
        {
            if (ch == c)
            {
                count++;
            }
        }
        return count;
    }
}

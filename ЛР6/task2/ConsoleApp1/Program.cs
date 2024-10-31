using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        // Удаляем все символы 'x'
        string result = RemoveCharacter(input, 'x');

        // Выводим результат
        Console.WriteLine("Результат без символов 'x':");
        Console.WriteLine(result);
    }

    static string RemoveCharacter(string str, char characterToRemove)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in str)
        {
            if (c != characterToRemove) // Проверяем, не является ли символ тем, который нужно удалить
            {
                sb.Append(c); // Добавляем символ в StringBuilder
            }
        }

        return sb.ToString(); // Возвращаем результат как строку
    }
}
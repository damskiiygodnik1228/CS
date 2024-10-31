using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текстовое сообщение:");
        string input = Console.ReadLine();

        Console.WriteLine("Введите символ, на который должны заканчиваться слова для удаления:");
        char characterToRemove = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Для перехода на новую строку

        // Удаляем слова, заканчивающиеся на заданный символ
        string result = RemoveWordsEndingWithCharacter(input, characterToRemove);

        // Выводим результат
        Console.WriteLine("Результат без слов, заканчивающихся на '{0}':", characterToRemove);
        Console.WriteLine(result);
    }

    static string RemoveWordsEndingWithCharacter(string str, char characterToRemove)
    {
        StringBuilder sb = new StringBuilder();

        // Разделяем строку на слова
        string[] words = str.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '-', 'n', 'r' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (word.Length == 0 || word[word.Length - 1] != characterToRemove) // Проверяем, не заканчивается ли слово на заданный символ
            {
                sb.Append(word + " "); // Добавляем слово в StringBuilder с пробелом
            }
        }

        // Удаляем последний пробел, если он есть
        if (sb.Length > 0)
            sb.Length--;

        return sb.ToString(); // Возвращаем результат как строку
    }
}

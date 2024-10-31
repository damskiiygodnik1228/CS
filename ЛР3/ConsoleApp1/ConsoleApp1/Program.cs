namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 6; i <= 10; i++)
            {
                // Определяем количество повторений в зависимости от текущего числа
                int repetitions = 11 - i; // Для 6 - 6 раз, для 7 - 4 раза и т.д.

                // Внутренний цикл для вывода повторений текущего числа
                for (int j = 0; j < repetitions; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine(); // Переход на новую строку после каждого числа
            }
            }
        }
}

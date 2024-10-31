
using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя количество строк матрицы
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        // Запрашиваем у пользователя количество столбцов матрицы
        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        // Создаем двумерный массив (матрицу) заданного размера
        int[,] matrix = new int[rows, cols];

        // Ввод элементов матрицы пользователем
        Console.WriteLine("Введите элементы матрицы (по строкам):");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Запрашиваем элемент матрицы по индексам [i, j]
                Console.Write($"Элемент [{i}, {j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Подсчитываем количество упорядоченных по возрастанию столбцов
        int count = CountSortedColumns(matrix);

        // Выводим результат на экран
        Console.WriteLine($"Количество упорядоченных по возрастанию столбцов: {count}");
    }

    // Метод для подсчета количества упорядоченных по возрастанию столбцов
    static int CountSortedColumns(int[,] matrix)
    {
        // Проверяем, что матрица не null и имеет ненулевые размеры
        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return 0;

        // Получаем количество строк и столбцов матрицы
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Переменная для подсчета упорядоченных столбцов
        int sortedColumnsCount = 0;

        // Перебираем каждый столбец матрицы
        for (int col = 0; col < cols; col++)
        {
            bool isSorted = true; // Предполагаем, что столбец упорядочен

            // Проверяем, упорядочен ли текущий столбец
            for (int row = 1; row < rows; row++)
            {
                // Если текущий элемент меньше предыдущего, столбец не упорядочен
                if (matrix[row, col] < matrix[row - 1, col])
                {
                    isSorted = false;
                    break; // Выходим из цикла, если нашли несоответствие
                }
            }

            // Если столбец упорядочен, увеличиваем счетчик
            if (isSorted)
            {
                sortedColumnsCount++;
            }
        }

        // Возвращаем общее количество упорядоченных столбцов
        return sortedColumnsCount;
    }
}

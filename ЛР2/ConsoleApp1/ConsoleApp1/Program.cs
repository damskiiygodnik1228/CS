namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x"); // Запрашиваем у пользователя ввод значения x
            double x = double.Parse(Console.ReadLine());  // Читаем ввод пользователя и преобразуем его в число типа double
            if (5 - x * x * x < 0) { Console.WriteLine("Данные неккоректны"); }// Проверяем, является ли выражение (5 - x^3) отрицательным
            else
            {
                double y = Math.Sqrt(5 - Math.Pow(x, 3));// Если выражение отрицательное, выводим сообщение об ошибке 
                Console.WriteLine($"y={y}"); // Выводим результат на экран
            }
        }

        
    }
}

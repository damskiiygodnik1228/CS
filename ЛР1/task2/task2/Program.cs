namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a= "); // Запрашиваем у пользователя ввод значения переменной a
            float a = float.Parse(Console.ReadLine());// Читаем введенное значение и преобразуем его в тип float
            Console.WriteLine("b= ");// Запрашиваем у пользователя ввод значения переменной b
            float b = float.Parse(Console.ReadLine());// Читаем введенное значение и преобразуем его в тип float

            Console.WriteLine("Площаадь:" + ((a*b)/2).ToString() );// Вычисляем площадь (половина произведения a и b) и выводим результат на экран

        }
    }
}

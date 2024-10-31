namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");// просим ввести число
            double a = double.Parse(Console.ReadLine());// Считываем и преобразуем введенное значение в тип double
            Console.Write("b= ");// просим ввести число
            double b = double.Parse(Console.ReadLine());// Считываем и преобразуем введенное значение в тип double
            Console.Write("h= ");// просим ввести шаг
            double h = double.Parse(Console.ReadLine());// Считываем и преобразуем введенное значение в тип double
            double y;
            int i = 1;
            Console.WriteLine("{0,3} {1,5} {1,5}", "#", "x", "f(x)");// Выводим заголовки таблицы
            for (double x = a; x <= b; x += h, ++i)// Цикл для вычисления значений функции от a до b с шагом h
            {
                if (Math.Abs(x) <= 1)// Если x находится в пределах от -1 до 1

                    y = Math.Pow(Math.Pow(x, 3) - 0.1, 2);// Вычисляем значение функции для данного x

                else
                {
                    if (Math.Abs(x) < 0.1 && Math.Abs(x) > 0.2) // Если x находится в диапазоне от -0.1 до 0.1 (исключая границы)
                    {
                        y = (0.2*x - 0.1);// Вычисляем другое значение функции
                    }
                    else
                    {
                        y = (Math.Pow(x, 3)  + 0.1);// Вычисляем значение функции для остальных случаев
                    }
                }
                Console.WriteLine("{0,3} {1,5:f2} {2,5:f2}", i, x, y);// Выводим номер строки, значение x и значение функции y с форматированием
            }


        }
    }
}


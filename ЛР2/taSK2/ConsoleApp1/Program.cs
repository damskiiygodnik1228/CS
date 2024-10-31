namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());// Читаем значение x из ввода пользователя и преобразуем его в тип double
            double y = double.Parse(Console.ReadLine());// Читаем значение y из ввода пользователя и преобразуем его в тип double

            if (Math.Pow(x,2) + Math.Pow(y,2) < 1 && y < 0)// Проверяем, находится ли точка (x, y) внутри круга радиусом 1 и ниже оси X
            { Console.WriteLine("Внутри");}
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2) > 1 || y > 0)) { Console.WriteLine("Снаружи"); }// Проверяем, находится ли точка (x, y) снаружи круга или выше оси X
            else { Console.WriteLine("На границе"); } // Если точка на границе круга, выводим "На границе"


        }
    }
}

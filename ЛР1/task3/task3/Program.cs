using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());// Читаем ввод пользователя и преобразуем его в целое число

            int sum = a / 10 + a % 10; // Единицы

            Console.WriteLine((sum % 10 == 0) ? "Заканчивается" : "Незаканчивается");// Проверяем, заканчивается ли сумма на 0 и выводим соответствующее сообщение

        }
    }
}

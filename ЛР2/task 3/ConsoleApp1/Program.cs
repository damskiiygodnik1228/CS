namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m; // Масть
            int k; // Достоинство

            Console.Write("Введите номер масти (1 - пики, 2 - трефы, 3 - бубны, 4 - червы): ");  // Запрашиваем у пользователя ввод номера масти и выводим соответствующее сообщение
            m = int.Parse(Console.ReadLine()); // Читаем ввод и преобразуем его в целое число

            // Запрашиваем у пользователя ввод номера достоинства и выводим соответствующее сообщение
            Console.Write("Введите номер достоинства (6 - 14): ");
            k = int.Parse(Console.ReadLine()); // Читаем ввод и преобразуем его в целое число

            string suit = "";
            string rank = "";

            // Определяем масть с помощью switch
            switch (m)
            {
                case 1:
                    suit = "пик";
                    break;
                case 2:
                    suit = "треф";
                    break;
                case 3:
                    suit = "бубен";
                    break;
                case 4:
                    suit = "черва";
                    break;
                default:
                    suit = "Некорректный номер масти";
                    break;
            }

            // Определяем достоинство с помощью switch
            switch (k)
            {
                case 6:
                    rank = "шесть";
                    break;
                case 7:
                    rank = "семь";
                    break;
                case 8:
                    rank = "восемь";
                    break;
                case 9:
                    rank = "девять";
                    break;
                case 10:
                    rank = "десять";
                    break;
                case 11:
                    rank = "валет";
                    break;
                case 12:
                    rank = "дама";
                    break;
                case 13:
                    rank = "король";
                    break;
                case 14:
                    rank = "туз";
                    break;
                default:
                    rank = "Некорректный номер достоинства";
                    break;
            }
            Console.WriteLine(suit + " " + rank);

        }
    }
}

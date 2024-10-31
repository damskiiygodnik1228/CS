namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");//задаем значение а 
            float a = float.Parse(Console.ReadLine());//задаем тип данных 
            Console.WriteLine("b=");// задаем значение b
            float b = float.Parse(Console.ReadLine());// задаем тип данных
            Console.WriteLine($"{a} * {b} = {string.Format("{0}", a * b)}");// выводим результат


        }
    }
}

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                Console.Write("n= ");
                var n1 = Console.ReadLine();
                byte n = byte.Parse(n1);
                for (byte i = 1; i <= n; ++i)
                {
                    for (byte j = 1; j <= i; ++j)
                    {
                        Console.Write("{0,4}", i);
                    }
                    Console.WriteLine();
                    for (byte j = 1; j <= i; ++j)
                    {
                        Console.Write("{0,4}", i + 2);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

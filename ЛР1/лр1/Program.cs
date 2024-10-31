using System;
namespace Example
{
    class Program
    {
        static void Main()
        {
            Console.Write("p =");
            double p = double.Parse(Console.ReadLine());
            double s = Math.Pow(p / 4, 2);
            Console.WriteLine(&quot; s{ 0}= &quot;, s);
        }
    }
}
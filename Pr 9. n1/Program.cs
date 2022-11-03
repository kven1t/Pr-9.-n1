using System.Runtime.Serialization.Formatters;

namespace Pr_9._n1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Курс доллара к рублю: ");
            double kyrs = double.Parse(Console.ReadLine());
            Console.Write("\n");
            for (int i = 5; i <= 500; i += 5)
            {
                Console.WriteLine($"{i}$ - {i * kyrs}Р");
            }
        }
    }
}
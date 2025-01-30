using System.Xml.Linq;

namespace Modul__3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your name is {0} and age is {1}", name, age);
            Console.WriteLine();

            Console.Write("Enter your brite date: ");
            var britedate = Console.ReadLine();

            Console.Write("Your brite date is {0}", britedate);
            Console.ReadKey();

        }
    }
}

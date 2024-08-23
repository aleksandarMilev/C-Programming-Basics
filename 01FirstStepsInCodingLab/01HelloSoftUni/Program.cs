using System;
namespace _01HelloSoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello SoftUni");
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            char temp = firstChar;
            firstChar = secondChar;
            secondChar = temp;

            Console.WriteLine(firstChar);
            Console.WriteLine(secondChar);
        }
    }
}
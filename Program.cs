using System;
namespace CodeChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Balancedsum name = new Balancedsum();
            int[] number = { 4, 6, 7, 10 };
            Console.WriteLine(name.balancedSum());
        }
    }
}


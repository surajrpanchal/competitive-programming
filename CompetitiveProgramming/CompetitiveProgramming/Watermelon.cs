using System;

namespace CompetitiveProgramming
{
    class Watermelon
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            if (i % 2 == 0 && i != 2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveProgramming
{
    class WayTooLongWords
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            List<string> values = new List<string>();
            for (int j = 1; j <= i; j++)
            {
                string value = Console.ReadLine();
                values.Add(value.Length > 100 ? value.Remove(100) : value);
            }
            for (int j = 0; j < values.Count; j++)
            {
                string value = values[j];
                if (value.Length > 10)
                {
                    string newValue2 = value.Remove(0, 1).Remove(value.Length - 2);
                    value = string.Concat(value[0], newValue2.Length, value[^1]);
                }
                Console.WriteLine(value);
            }
        }

    }
}

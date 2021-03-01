using System;
using System.Collections;

namespace LuckyTicket
{
    class Program
    {
        static bool IsNumberContains(char[] input)
        {
            foreach (char c in input)
                if (Char.IsLetter(c))
                    return false;

            return true;
        }

        static void IsLucky(ArrayList ticket)
        {
            int part1 = 0;
            int part2 = 0;

            int len = ticket.Count / 2;

            for (int i = 0, j = len; i < len; i++, j++)
            {
                part1 += (int)ticket[i];
                part2 += (int)ticket[j];
            }

            if (part1 == part2)
                Console.WriteLine("Ticket is lucky");
            else
                Console.WriteLine("Ticket is not lucky");
        }
        static void Main(string[] args)
        {
            do
            {
                ArrayList ticket = new ArrayList();

                char[] input;

                bool isAllNumeric = false;

                do
                {
                    Console.WriteLine("Enter ticket number");

                    input = Console.ReadLine().ToCharArray();

                    if (input.Length >= 4 && input.Length <= 8)
                    {
                        isAllNumeric = IsNumberContains(input);
                    }
                }
                while (isAllNumeric == false);

                foreach (char ch in input)
                    ticket.Add(Convert.ToInt32(new string(ch, 1)));

                if (ticket.Count % 2 != 0)
                {
                    ticket.Insert(0, 0);
                }

                IsLucky(ticket);
            }
            while (true);

            Console.ReadLine();
        }
    }
}

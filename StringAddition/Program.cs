using System;

namespace StringAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings! Please type your first initial:");
            string firstInitial = Console.ReadLine();
            Console.WriteLine("Now please type your middle initial:");
            string middleInitial = Console.ReadLine();
            Console.WriteLine("Now please type your last initial:");
            string lastInitial = Console.ReadLine();
            string allInitial = firstInitial + middleInitial + lastInitial;
            Console.WriteLine("Your Initials all together are " + allInitial + ".");
            Console.ReadLine();
        }
    }
}

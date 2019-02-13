using System;


namespace LifeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Jesus = new Person();
            Jesus.Start();
            Console.WriteLine("You wake up. You are still in bed.");
            Console.WriteLine("There is a person sitting next to you.");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[1] Stay in bed");
            Console.WriteLine("[2] Talk to man");
            Console.WriteLine("[3] Get out of bed and walk away from man?");
            string input;
            input = Console.ReadLine(); Console.WriteLine();
            if (input == "1")
            {
                Console.WriteLine("The man had a knife. He killed you.");
            }
            if (input == "2")
            {
                Console.WriteLine("The man asks you: ");
                Jesus.Interact();
            }
            Console.WriteLine();
        }
    }
}

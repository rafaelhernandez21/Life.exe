using System;
namespace LifeTest
{
    public class Person
    {
        System.Collections.Generic.List<Choice> choiceFunctions = new System.Collections.Generic.List<Choice>();
        Choice[] choices;
        public void Start()
        {
            Choice Jesus = new Choice("Jesus?", BecomeJesus);
            Choice Killhim = new Choice("Kill!", Kill);
            choiceFunctions.Add(Jesus);
            choiceFunctions.Add(Killhim);
            choices = choiceFunctions.ToArray();
        }
        void BecomeJesus()
        {
            Console.WriteLine("You became Jesus");
            Console.WriteLine("Congrats!");
        }
        void Kill()
        {
            Console.WriteLine("You killed an innocent man, what is wrong with you?");
            Console.WriteLine("Is it because he looked a bit like Hitler?");
            Console.WriteLine("It was just slightly! He didn't even have the mustache!");
        }
        public void Interact()
        {
            Console.WriteLine("What do you want?");
            Console.WriteLine();
            Console.WriteLine("[1] " + choices[0].prompt);
            Console.WriteLine("[2] " + choices[1].prompt);
            string i = Console.ReadLine();
            if (i == "1")
            {
                choices[0].choiceAction();
            }
            else if (i == "2")
            {
                choices[1].choiceAction();
            }
        }
    }
}

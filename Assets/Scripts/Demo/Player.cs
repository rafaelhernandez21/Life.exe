using System;
namespace LifeTest
{
    public class Player : Character
    {
        public string name;

       public void Start() {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            MakeValues();
            Console.WriteLine("Intelligence: " + intel.points);
            Console.WriteLine("Strength: " + str.points);
            Console.WriteLine("Endurance: "+ endur.points);
            Console.WriteLine("Charisma: " + cha.points);

        }
        public Player()
        {
        }
    }
}

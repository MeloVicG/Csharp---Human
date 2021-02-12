using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human("Victor", 5,20);
            Human person2 = new Human("Zach", 4,19);
            Console.WriteLine($"i am {person.Dexterity}");
            person.Attack(person2);
            
        }
    }
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
        {
            get {return health;}
        }
        
        
        //Constructor
        public Human(string name, int str, int intel, int dex = 3, int hea = 100)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hea;
        }

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values

        // Add a constructor to assign custom values to all fields

        // Build Attack method
        public int Attack(Human target)
        {
            int damage = Strength * 5;
            target.health = target.health - damage;
            Console.WriteLine($"{target.Name} is being attacked, health is {target.health} ");
            return target.health;
        }

    }
}

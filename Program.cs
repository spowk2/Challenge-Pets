using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pet
    {
        public string type
        {
            set;
            get;
        }
        public string name
        {
            set;
            get;
        }
        public string owner
        {
            set;
            get;
        }
        public double weight
        {
            set;
            get;
        }
        public Pet(string type, string name, string owner, double weight)
        {
            this.type = type;
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }
        public string getTag()
        {
            return "If lost, call " + this.owner + ".";
        }
    }

    class Dog : Pet
    {
        public Dog(string name, string owner, double weight)
        : base(string.Empty, name, owner, weight)
        {
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }
        public string bark(int count)
        {
            string bark = "";
            for (int i = 0; i < count; i++)
            {
                bark = bark + "bark!";
            }
            return bark;
        }
    }

    class Cat : Pet
    {
        public Cat(string name, string owner, double weight)
        : base(string.Empty, name, owner, weight)
        {
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }
        public string meow(int count)
        {
            string meow = "";
            for (int i = 0; i < count; i++)
            {
                meow = meow + "meow.";
            }
            return meow;
        }


        static void Main(string[] args)
        {
            Pet pet1 = new Pet("dog", "Shadow", "Jose", 42.6);
            Console.WriteLine("Name: " + pet1.name);
            Console.WriteLine("Weight: " + pet1.weight);
            Console.WriteLine(pet1.getTag());
            Console.WriteLine();
            Dog dog1 = new Dog("Daisy", "Kent", 23.4);
            Console.WriteLine("Name: " + dog1.name);
            Console.WriteLine("Weight: " + dog1.weight);
            Console.WriteLine(dog1.getTag());
            Console.WriteLine(dog1.bark(4));
            Console.WriteLine();
            Cat cat1 = new Cat("Simba", "Maria", 5.2);
            Console.WriteLine("Name: " + cat1.name);
            Console.WriteLine("Weight: " + cat1.weight);
            Console.WriteLine(cat1.getTag());
            Console.WriteLine(cat1.meow(3));
            Console.WriteLine();

        }
    }
}
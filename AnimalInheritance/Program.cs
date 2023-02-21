using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }

    class Blobfish : Animal
    {
        public int age;
        public int weight;
        public string favFood;
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setWeight(int weight)
        {
            this.weight = weight;
        }
        public void setFavFood(string favFood)
        {
            this.favFood = favFood;
        }
        public override string getName()
        {
            return base.getName();
        }
        public override string getType()
        {
            return type;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal gary = new Animal();
            gary.setName("Gary");
            gary.setType("Snail");
            gary.color= "pink";

            Console.WriteLine("...Animal Biography...");
            Console.WriteLine($"My name is {gary.getName()}");
            Console.WriteLine($"I am a {gary.getType()}");
            Console.WriteLine($"I am a lovely {gary.color} color");
            Console.WriteLine();

            Blobfish blobby = new Blobfish();
            blobby.setName("Blobby");
            blobby.setType("BlobFish");
            blobby.color = "pink";
            blobby.age = 78;
            blobby.weight = 20;
            blobby.favFood = "crustaceans";
            Console.WriteLine("...BlobFish Biography...");
            Console.WriteLine($"My name is {blobby.getName()}");
            Console.WriteLine($"I am a {blobby.getType()}");
            Console.WriteLine($"I am a lovely {blobby.color} color");
            Console.WriteLine($"I am {blobby.age} years old");
            Console.WriteLine($"I weigh around {blobby.weight} lbs");
            Console.WriteLine($"My favorite food is {blobby.favFood}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Classes;
using Animals.Interfaces;

namespace Animals
{
    class AnimalsTest
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Cat("Maca",3,"female"),
                new Kitten("Sir Mittens the Third",1),
                new Tomcat("Scar",4),
                new Dog("Sharo",3,"male"),
                new Frog("Croaker",1,"male"),
                new Kitten("Dr Whiskers van Purrr",1),
                new Cat("I can haz cheeseburger?",2,"female"),
                new Kitten("Gray",2),
                new Dog("Poncho",1,"male")
            };
            var ageCats = animals.Where(animal => animal is Cat).Select(animal => animal.Age).Average();
            var ageDogs = animals.Where(animal => animal is Dog).Select(animal => animal.Age).Average();
            var ageFrogs = animals.Where(animal => animal is Frog).Select(animal => animal.Age).Average();

            Console.WriteLine("Average age of cats: {0}",ageCats);
            Console.WriteLine("Average age of dogs: {0}",ageDogs);
            Console.WriteLine("Average age of frogs: {0}",ageFrogs);

            Kitten sirMittens = new Kitten("Sir Mittens the Third", 1);
            Dog poncho = new Dog("Poncho", 1, "male");
            Frog croaker = new Frog("Croaker", 1, "male");
            Cat cheeseburger = new Cat("I can haz cheeseburger?", 2, "female");
            Tomcat scar = new Tomcat("Scar", 4);

            Console.WriteLine();
            cheeseburger.ProduceSound();
            scar.ProduceSound();
            croaker.ProduceSound();
            poncho.ProduceSound();
            sirMittens.ProduceSound();
        }
    }
}

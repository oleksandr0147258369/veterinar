using System;
using System.Collections.Generic;
using Bogus;

namespace cw_1
{
    public class Animal
    {
        public string Poroda { get; set; }
        public string Vyd { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public Animal()
        {
            Poroda = "";
            Vyd = "";
            Weight = 0;
            Age = 0;
            Name = "";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Breed: {Poroda}, Type: {Vyd}, Weight: {Weight}kg, Age: {Age} years";
        }
    }

    public class AnimalArray
    {
        public Animal[] GenerateArray(int size)
        {
            Animal[] arr = new Animal[size];
            Faker faker = new Faker();

            for (int i = 0; i < size; i++)
            {
                arr[i] = new Animal
                {
                    Poroda = faker.Commerce.ProductName(),
                    Vyd = faker.Random.Word(),
                    Weight = faker.Random.Number(5, 100),
                    Age = faker.Random.Number(1, 15),
                    Name = faker.Name.FirstName()
                };
            }

            return arr;
        }
    }

    public class VeterinaryClinic
    {
        public delegate void AllAnimalsProcessedHandler();
        public event AllAnimalsProcessedHandler OnAllAnimalsProcessed;

        public void ProcessAnimals(Animal[] animals)
        {
            Random random = new Random();
            int totalTime = 0;

            Console.WriteLine("Veterinarian is processing animals:");

            foreach (Animal animal in animals)
            {
                int processingTime = random.Next(5, 21);
                totalTime += processingTime;
                Console.WriteLine($"Processing {animal.Name}. Time required: {processingTime} minutes.");
                System.Threading.Thread.Sleep(500);
            }

            Console.WriteLine($"All animals have been processed. Total time: {totalTime} minutes.");

            OnAllAnimalsProcessed?.Invoke();
        }
    }

    public class Program
    {
        public static void AnswerOnEvent()
        {
            Console.WriteLine("Event: All animals have been successfully processed!");
        }
        static void Main(string[] args)
        {
            int numberOfAnimals = 10;

            AnimalArray animalArray = new AnimalArray();
            Animal[] animals = animalArray.GenerateArray(numberOfAnimals);

            Console.WriteLine("Generated animals:");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }

            VeterinaryClinic clinic = new VeterinaryClinic();
            clinic.OnAllAnimalsProcessed += AnswerOnEvent;

            clinic.ProcessAnimals(animals);

            Console.ReadKey();
        }
    }
}
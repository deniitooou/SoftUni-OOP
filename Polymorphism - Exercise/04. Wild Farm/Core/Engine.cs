namespace WildFarm.Core
{
    using System;
    using System.Collections.Generic;

    using Exceptions;

    using Factories.Interfaces;
    using Interfaces;
    using IO.Interfaces;
    using Models.Interfaces;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IAnimalFactory animalFactory;
        private readonly IFoodFactory foodFactory;

        private readonly ICollection<IAnimal> animals;

        private Engine()
        {
            this.animals = new HashSet<IAnimal>();
        }

        public Engine(IReader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory) : this()
        {
            this.reader = reader;
            this.writer = writer;

            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;
        }

        public void Run()
        {
            string command;

            while ((command = this.reader.ReadLine()) != "End")
            {
                this.HandleInput(command);
            }

            this.PrintAllAnimals();
        }

        private IAnimal BuildAnimalUsingFactory(string command)
        {
            string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            IAnimal currAnimal = this.animalFactory.CreateAnimal(cmdArgs);

            return currAnimal;
        }

        private IFood BuildFoodUsingFactory()
        {
            string[] foodArgs = this.reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string foodType = foodArgs[0];
            int foodQuality = int.Parse(foodArgs[1]);
            IFood currentlyFood = this.foodFactory.CreateFood(foodType, foodQuality);

            return currentlyFood;
        }

        private void HandleInput(string command)
        {
            IAnimal currentlyAnimal = null;

            try
            {
                currentlyAnimal = this.BuildAnimalUsingFactory(command);
                IFood currFood = this.BuildFoodUsingFactory();

                this.writer.WriteLine(currentlyAnimal.ProduceSound());
                currentlyAnimal.Eat(currFood);
            }

            catch (InvalidAnimalTypeException iate)
            {
                this.writer.WriteLine(iate.Message);
            }

            catch (InvalidFoodTypeException ifte)
            {
                this.writer.WriteLine(ifte.Message);
            }

            catch (FoodNotEatenException fnee)
            {
                this.writer.WriteLine(fnee.Message);
            }

            catch (Exception)
            {
                throw;
            }

            this.animals.Add(currentlyAnimal);
        }

        private void PrintAllAnimals()
        {
            foreach (IAnimal animal in this.animals)
            {
                this.writer.WriteLine(animal);
            }
        }
    }
}
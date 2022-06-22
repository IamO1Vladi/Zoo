using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {

        public List<Animal> Animals { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Zoo(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            Animals = new List<Animal>();
        }

        public string AddAnimal(Animal animal)
        {

            if (Animals.Count == Capacity)
            {
                return "The zoo is full.";
            }

            if(animal.Species==null ||animal.Species==" ")
            {
                return "Invalid animal species.";
            }

            if(animal.Diet!= "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }

            Animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }

        public int RemoveAnimals(string species)
        {
            int count = 0;

            foreach (var animal in Animals)
            {
                if (animal.Species == species)
                {
                    count++;
                }
            }

            Animals.RemoveAll(x => x.Species == species);
            return count;

        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {

            return Animals.Where(x => x.Diet == diet).ToList();
        }

       public Animal GetAnimalByWeight(double weight)
        {

            return Animals.FirstOrDefault(x => x.Weight == weight);
        }


        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {

            int count = 0;

            foreach (var animal in Animals)
            {
                if(animal.Length<=maximumLength && animal.Length >= minimumLength)
                {
                    count++;
                }
            }

            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}

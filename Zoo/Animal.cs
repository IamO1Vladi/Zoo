namespace Zoo
{
    public class Animal
    {
//        •	Species – string
//•	Diet – string
//•	Weight – double
//•	Length – double

        public string Species { get; set; }
        public string Diet { get; set; }
        public double Weight { get; set; }
        public double Length { get; set; }

        public Animal(string species,string diet,double weight,double lenght)
        {
            this.Species = species;
            this.Diet = diet;
            this.Weight = weight;
            this.Length = lenght;
        }

        public override string ToString()
        {
            return $"The {Species} is a {Diet} and weighs {Weight} kg.";
        }

    }
}

namespace SuperAwesomeFancyPants.InheritZoo.Animals
{
    public abstract class Mammal : Animal
    {
        protected Mammal(int weight)
        {
            Weight = weight;
        }

        public int MaxNumberOfChildernInWomb { get; set; } = 4;
    }
}
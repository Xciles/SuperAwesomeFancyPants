namespace SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Interfaces
{
    public interface IAnimal
    {
        bool IsHungry { get; set; }
        bool IsAlive { get; set; }
        string Name { get; set; }
        int Weight { get; set; }

        void Eat();
        void MakeSound();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using SuperAwesomeFancyPants.InheritZoo.Domain.Food;
using SuperAwesomeFancyPants.InheritZoo.Domain.Food.Interfaces;
using SuperAwesomeFancyPants.InheritZoo.Domain.Food.Meats;
using SuperAwesomeFancyPants.InheritZoo.Domain.Food.Plants;

namespace SuperAwesomeFancyPants.InheritZoo.Business
{
    public class FoodStock
    {
        private readonly IList<BaseFood> _foodStock = new List<BaseFood>();

        public FoodStock()
        {
            _foodStock.Add(new Meat() { Amount = 100, Name = "Pig" });
            _foodStock.Add(new Leaf() { Amount = 10, Name = "Oak" });
            _foodStock.Add(new Leaf() { Amount = 50, Name = "Pine" });
            _foodStock.Add(new Grass() { Amount = 1000, Name = "Nice Grass"});
        }

        public bool RemoveFoodFromStock<T>(float requiredAmountOfFood)
            where T : IFood
        {
            var availableFood = _foodStock.OfType<T>().Cast<BaseFood>().ToList();
            return RemoveFoodFromStock(availableFood, requiredAmountOfFood);
        }

        public bool RemoveFoodFromStock(Type typeOfFood, float requiredAmountOfFood)
        {
            var availableFood = _foodStock.Where(x => x.GetType() == typeOfFood).ToList();
            return RemoveFoodFromStock(availableFood, requiredAmountOfFood);
        }

        private bool RemoveFoodFromStock(IList<BaseFood> availableFood, float requiredAmountOfFood)
        {
            if (availableFood.Sum(x => x.Amount) < requiredAmountOfFood)
            {
                return false;
            }

            // remove the amount of food from the food things
            var amountOfFoodRemovedToBeRemoved = requiredAmountOfFood;
            foreach (var food in availableFood)
            {
                if (food.Amount - amountOfFoodRemovedToBeRemoved <= 0)
                {
                    amountOfFoodRemovedToBeRemoved -= food.Amount;
                    _foodStock.Remove(food);
                }
                else
                {
                    food.Amount -= amountOfFoodRemovedToBeRemoved;
                    return true;
                }
            }

            return false;
        }

        public void PrintInfo()
        {
            var type = typeof(IFood);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                                .SelectMany(s => s.GetTypes())
                                .Where(p => type.IsAssignableFrom(p) && !p.IsAbstract && !p.IsInterface);

            foreach (var typeOfAnimal in types)
            {
                Console.WriteLine($"Food Type: {typeOfAnimal.Name}, # of food: {_foodStock.Where(x => x.GetType() == typeOfAnimal).Sum(x => x.Amount)}");
            }
        }
    }
}
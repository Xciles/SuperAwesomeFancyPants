using System;
using System.Collections.Generic;
using System.Text;
using SuperAwesomeFancyPants.InheritZoo.Domain.Food.Interfaces;

namespace SuperAwesomeFancyPants.InheritZoo.Domain.Food
{
    public abstract class BaseFood : IFood
    {
        public string Name { get; set; }
        public float Amount { get; set; } = 10;
    }
}

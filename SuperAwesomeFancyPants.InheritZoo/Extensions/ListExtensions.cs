using System.Collections.Generic;
using System.Linq;

namespace SuperAwesomeFancyPants.InheritZoo.Extensions
{
    public static class ListExtensions
    {
        public static int NumberOfMammals<T, TCheck>(this IList<T> list)
        {
            return list.OfType<TCheck>().Count();
        }
    }
}
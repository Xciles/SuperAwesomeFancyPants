using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SuperAwesomeFancyPants.AdvWeb.Services
{
    public interface IGenericTest<T>
    {

    }

    public class GenericTest<T> : IGenericTest<T>
        where T : DbContext
    {
        private DbContext _context;

        public GenericTest(T context)
        {
            _context = context;
        }
    }
}

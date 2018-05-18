using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAwesomeFancyPants.AdvWeb.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        
        public Student Student { get; set; }
        public int StudentId { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Blog> Blogs { get;set; }
    }
}

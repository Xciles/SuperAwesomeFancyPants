using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SuperAwesomeFancyPants.AdvWeb.Data;
using SuperAwesomeFancyPants.AdvWeb.Models;
using SuperAwesomeFancyPants.AdvWeb.Services;

namespace SuperAwesomeFancyPants.AdvWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericTest<ApplicationDbContext> _genTest;
        private readonly DbContext _context;

        public HomeController(IGenericTest<ApplicationDbContext> genTest, ApplicationDbContext context)
        {
            _genTest = genTest;
            _context = context;

            var number = 1234;
            

            var number2 = number;
            var name = "hansje";

            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                
            }

        }

        public async Task<IActionResult> Index()
        {
            var result = (from s in _context.Set<Student>()
                          select s);

            result = result.Where(x => x.Name == "Hansje");

            result.ToList();

            //var student = new Student { Name = "Hansje" };
            //_context.Set<Student>().Add(student);
            ////_context.Students.Add(student);
            //await _context.SaveChangesAsync();

            //var blog = new Blog
            //{
            //    Text = "Blaaaa",
            //    Title = "Aaaaa",
            //    Url = "https://google.com",
            //    StudentId = student.Id
            //};
            //_context.Set<Blog>().Add(blog);
            //await _context.SaveChangesAsync();


            //var studentMatthijs = new Student { Name = "Mathijs" };
            //_context.Set<Student>().Add(studentMatthijs);

            //var blogMatthijs = new Blog
            //{
            //    Text = "Mooie blog",
            //    Title = "Aaaaa",
            //    Url = "https://google.com",
            //    Student = studentMatthijs
            //};
            //_context.Set<Blog>().Add(blogMatthijs);
            //await _context.SaveChangesAsync();




























            var tokenSource = new CancellationTokenSource(10_000);

            Task.Run(() => { }, tokenSource.Token);

            using (var transaction = _context.Database.BeginTransaction())
            {
                //_context.Database.CurrentTransaction
                _context.Database.CommitTransaction();
                try
                {
                    var student = new Student { Name = "Hansje" };
                    _context.Set<Student>().Add(student);
                    //_context.Students.Add(student);
                    await _context.SaveChangesAsync();

                    var blog = new Blog
                    {
                        Text = "Blaaaa",
                        Title = "Aaaaa",
                        Url = "https://google.com",
                        StudentId = student.Id
                    };
                    _context.Set<Blog>().Add(blog);
                    await _context.SaveChangesAsync(tokenSource.Token);

                    // check

                    var studentMatthijs = new Student { Name = "Mathijs" };
                    _context.Set<Student>().Add(studentMatthijs);

                    var blogMatthijs = new Blog
                    {
                        Text = "Mooie blog",
                        Title = "Aaaaa",
                        Url = "https://google.com",
                        Student = studentMatthijs
                    };
                    _context.Set<Blog>().Add(blogMatthijs);
                    await _context.SaveChangesAsync();

                    var list = await _context.Set<Blog>().ToListAsync();
                    foreach (var blog1 in list)
                    {
                        if (blog1.Title == "Aaaaa")
                        {
                            transaction.Rollback();

                            return View();
                        }   
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error occurred.");
                }
            }


            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieMagic.Models;

namespace MovieMagic
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Test();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }

        private static void ReadArgs(string[] args)
        {
            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "hi":
                        Console.WriteLine("Hello World!");
                        break;
                    case "foo":
                        Console.WriteLine("bar");
                        break;
                    default:
                        Console.WriteLine($"{args[0]} is not a valid command, please try again");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Unable to process your request.");
            }
        }

        private static void Test()
        {
            var ctx = new MovieContext();
            ctx.Movies.Add(new Movie(){Title = "Test Title"});
            ctx.SaveChanges();


            var movies = ctx.Movies.ToList();
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Id}: {movie.Title}");
            }
        }
    }
}

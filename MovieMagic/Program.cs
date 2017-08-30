using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieMagic.Models;

namespace MovieMagic
{
    //check out code first migrations here: https://msdn.microsoft.com/en-us/library/jj591621(v=vs.113).aspx

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ReadArgs(args);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }

        private static void ReadArgs(string[] args)
        {
            var ctx = new MovieContext();
          

            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "addMovie":
                        Console.WriteLine();
                        Console.WriteLine("Adding a new movie...");
                        Console.WriteLine();
                        Console.WriteLine("What is the movie's title?");
                        var title = Console.ReadLine();

                        var movie = new Movie();
                        movie.Title = title;

                        ctx.Movies.Add(movie);
                        ctx.SaveChanges();

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
    }
}

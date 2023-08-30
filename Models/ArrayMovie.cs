using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMovieAppArray.Models
{

    class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Movie(int id, string name, string genre, int year)
        {
            Id = id;
            Name = name;
            Genre = genre;
            Year = year;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Genre: {Genre}, Year: {Year}";
        }
    }
    internal class ArrayMovie
    {
        private const int MaxMovies = 5;
        private Movie[] movies;
        private int movieCount;

        public ArrayMovie()
        {
            movies = new Movie[MaxMovies];
            movieCount = 0;
        }
     

        public void Run()
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Display movies");
                Console.WriteLine("2. Add a movie");
                Console.WriteLine("3. Clear all movies");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayMovies();
                        break;

                    case 2:
                        if (movieCount < MaxMovies)
                        {
                            AddMovie();
                        }
                        else
                        {
                            Console.WriteLine("Maximum movie limit reached.");
                        }
                        break;

                    case 3:
                        ClearMovies();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } while (choice != 4);
        }

        private void DisplayMovies()
        {
            Console.WriteLine("Movies:");
            for (int i = 0; i < movieCount; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }

        private void AddMovie()
        {
            Console.WriteLine("Enter movie details:");
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Genre: ");
            string genre = Console.ReadLine();

            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Movie newMovie = new Movie(id, name, genre, year);
            movies[movieCount] = newMovie;
            movieCount++;

            Console.WriteLine("Movie added successfully.");
        }

        private void ClearMovies()
        {
            movies = new Movie[MaxMovies];
            movieCount = 0;
            Console.WriteLine("All movies cleared.");
        }
    }
}

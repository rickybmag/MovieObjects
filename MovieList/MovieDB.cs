using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class MovieDB
    {
        public List<Movies> MovieLists { get; set; } = new List<Movies>();
        public MovieDB()
        {
            MovieLists.Add(new Movies("The Thing", "Horror"));
            MovieLists.Add(new Movies("Saw", "Horror"));
            MovieLists.Add(new Movies("Wedding Crashers", "Comedy"));
            MovieLists.Add(new Movies("Vacation Friends", "Comedy"));
            MovieLists.Add(new Movies("Knives Out", "Thriller"));
            MovieLists.Add(new Movies("The Hunt", "Thriller"));
            MovieLists.Add(new Movies("Luca", "Animation"));
            MovieLists.Add(new Movies("Batman vs. The Ninja Turtles", "Animation"));
            MovieLists.Add(new Movies("The Running Man", "Action"));
            MovieLists.Add(new Movies("Robocop", "Action"));
        }

        public string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            Console.WriteLine();
            return input;
        }

        public void PrintTitles()
        {
            for (int i = 1; i < MovieLists.Count; i++)
            {
                Movies mov = MovieLists[i];
                Console.WriteLine($"{i} : {mov.Title}");                
            }
            Console.WriteLine();
        }

        public void PrintGenres()
        {
            for (int i = 1; i < MovieLists.Count; i++)
            {
                Movies mov = MovieLists[i];
                Console.WriteLine($"{i} : {mov.Genre}");
            }
            Console.WriteLine();
        }

        public void SearchListByGenre(string genre)
        {
            for (int i = 0; i < MovieLists.Count; i++)
            {
                Movies list = MovieLists[i];
                if (list.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        Console.WriteLine("Movie Title: " + list.Title);
                        Console.WriteLine("Genre: " + list.Genre);
                        Console.WriteLine();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine($"{genre} was not found on the list. Please try again");
                    }
                }
            }
        }                
    }
}

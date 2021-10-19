using System;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;

            while (goOn)
            {
                MovieDB titles = new MovieDB();
                //titles.PrintGenres();
                string input = titles.GetInput("\n*******************\n\nHello! Please select from the following categories:\nHorror\nComedy\nThriller\nAnimation\nAction\n\n*******************");
                Console.WriteLine();

                titles.SearchListByGenre(input);


                goOn = Continue();
                Console.WriteLine();
            }
            
        }

        public static bool Continue()
        {
            Console.WriteLine("Would you like to look at other movies? (Y/N)");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("See you soon!");
                return false;
            }
            else
            {
                Console.WriteLine("Please Try again");
                Console.WriteLine();
                return Continue();
            }
        }

    }
}

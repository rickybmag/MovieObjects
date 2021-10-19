using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class Movies
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        //This is initialized the property with a default value
        public bool IsCompleted { get; set; } = false;
        public Movies(string Title, string Genre)
        {
            this.Title = Title;
            this.Genre = Genre;
        }
    }
}
